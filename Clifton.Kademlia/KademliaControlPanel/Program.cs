using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

using Clifton.Kademlia;
using Clifton.Kademlia.Common;
using Clifton.Kademlia.Protocols;
using Clifton.Kademlia.Store.DBreeze;

namespace KademliaControlPanel
{
    public static class Program
    {
        private static TcpServer server;
        private static Dht dht;
        private static IStorage localStore;
        private static IStorage republishStore;
        private static IStorage cacheStore;

        private static string url;
        private static int port;
        // private static int subnet;
        private static string peerID;
        private static string fnLocalStore;
        private static string fnRepublishStore;

        public const string DHT_FILENAME = "kademlia.dht";
        private const string CONFIG_URL = "url";
        private const string CONFIG_PORT = "port";
        private const string CONFIG_SUBNET = "subnet";
        private const string CONFIG_PEER_ID = "peerID";
        private const string CONFIG_LOCAL_STORE = "localStore";
        private const string CONFIG_REPUBLISH_STORE = "republishStore";

        [STAThread]
        static void Main()
        {
            LoadConfig();
            InitializeKademlia();
            InitializeServer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new ControlPanel(dht));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                server.Stop();
            }
        }

        private static void InitializeKademlia()
        {
            ID id = new ID(peerID);

            if (File.Exists(DHT_FILENAME))
            {
                dht = Dht.Load(File.ReadAllText(DHT_FILENAME));
                ((DBreezeStore)dht.OriginatorStorage).Open(fnLocalStore);
                ((DBreezeStore)dht.RepublishStorage).Open(fnRepublishStore);
                localStore = dht.OriginatorStorage;
                republishStore = dht.RepublishStorage;
                cacheStore = new VirtualStorage();
                dht.CacheStorage = cacheStore;
                dht.FinishLoad();
            }
            else
            {
                localStore = new DBreezeStore(fnLocalStore);
                republishStore = new DBreezeStore(fnRepublishStore);
                cacheStore = new VirtualStorage();
                dht = new Dht(id, new TcpProtocol(url, port), new ParallelRouter(), localStore, republishStore, cacheStore);
            }
        }

        private static void InitializeServer()
        {
            server = new TcpServer(url, port);
            server.RegisterProtocol(dht.Node);
            server.Start();
        }

        private static void LoadConfig()
        {
            peerID = ConfigurationManager.AppSettings[CONFIG_PEER_ID];
            url = ConfigurationManager.AppSettings[CONFIG_URL];
            port = ConfigurationManager.AppSettings[CONFIG_PORT].to_i();
            // subnet = ConfigurationManager.AppSettings[CONFIG_SUBNET].to_i();
            fnLocalStore = ConfigurationManager.AppSettings[CONFIG_LOCAL_STORE];
            fnRepublishStore = ConfigurationManager.AppSettings[CONFIG_REPUBLISH_STORE];
        }
    }
}
