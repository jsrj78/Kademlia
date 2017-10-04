using System;
using System.Configuration;
using System.Windows.Forms;

using Clifton.Kademlia;
using Clifton.Kademlia.Common;
using Clifton.Kademlia.Protocols;
using Clifton.Kademlia.Store.DBreeze;

namespace KademliaControlPanel
{
    public static class Program
    {
        public static TcpServer server;
        public static Dht dht;
        public static DBreezeStore localStore;
        public static DBreezeStore republishStore;
        public static VirtualStorage cacheStore;

        public static string url;
        public static int port;
        public static string peerID;
        public static string fnLocalStore;
        public static string fnRepublishStore;

        private const string CONFIG_URL = "url";
        private const string CONFIG_PORT = "port";
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
                Application.Run(new ControlPanel());
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
            localStore = new DBreezeStore(fnLocalStore);
            republishStore = new DBreezeStore(fnRepublishStore);
            cacheStore = new VirtualStorage();
            dht = new Dht(id, new TcpProtocol(url, port), new ParallelRouter(), localStore, republishStore, cacheStore);
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
            fnLocalStore = ConfigurationManager.AppSettings[CONFIG_LOCAL_STORE];
            fnRepublishStore = ConfigurationManager.AppSettings[CONFIG_REPUBLISH_STORE];
        }
    }
}
