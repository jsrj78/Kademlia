using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

using Clifton.Core.ExtensionMethods;

using Clifton.Kademlia;
using Clifton.Kademlia.Common;
using Clifton.Kademlia.Protocols;

namespace KademliaControlPanel
{
    public partial class ControlPanel : Form
    {
        protected TreeNode nodePeers;
        protected TreeNode nodePendingPeers;
        protected TreeNode nodeLocalStore;
        protected TreeNode nodeRepublishStore;
        protected TreeNode nodeCacheStore;

        protected Dht dht;

        private const int VISIBLE_KEY_LENGTH = 10;

        public ControlPanel(Dht dht)
        {
            this.dht = dht;
            InitializeComponent();
            tbOurPeerUrl.Text = dht.Protocol.Url;
            tbOurPeerPort.Text = dht.Protocol.Port.ToString();
            // tbOurPeerSubnet.Text = dht.Protocol.Subnet.ToString();
            nodePeers = tvPeerState.Nodes.Add("Peers");
            nodePendingPeers = tvPeerState.Nodes.Add("Pending Peers");
            TreeNode storageNode = tvPeerState.Nodes.Add("Storage");
            nodeLocalStore = storageNode.Nodes.Add("Local Store");
            nodeRepublishStore = storageNode.Nodes.Add("Republish Store");
            nodeCacheStore = storageNode.Nodes.Add("Cache Store");
            tvPeerState.ExpandAll();
            PopulatePeerNodes();
            PopulateStorageNodes();
            Text = "Peer " + dht.Protocol.Port.ToString();
            FormClosing += (sndr, args) => SaveDht();

            dht.PendingContactAdded += (sndr, args) => PendingContactAdded(args.Contact);
            dht.PendingContactRemoved += (sndr, args) => PendingContactRemoved(args.Contact);
            dht.ContactAdded += (sndr, args) => ContactAdded(args.Contact);
            dht.ContactRemoved += (sndr, args) => ContactRemoved(args.Contact);

            dht.OriginatorStoreAdded += (sndr, args) => OriginatorStoreAdded(args.Key);
            dht.RepublishStoreAdded += (sndr, args) => RepublishStoreAdded(args.Key);
            dht.RepublishStoreRemoved += (sndr, args) => RepublishStoreRemoved(args.Key);
            dht.CacheStoreAdded += (sndr, args) => CacheStoreAdded(args.Key);
            dht.CacheStoreRemoved += (sndr, args) => CacheStoreRemoved(args.Key);
        }

        protected void PendingContactAdded(Contact contact)
        {
            this.BeginInvoke(() => nodePendingPeers.Nodes.Add(contact.Protocol.Description).Tag = contact);
        }

        protected void PendingContactRemoved(Contact contact)
        {
            this.BeginInvoke(() => nodePendingPeers.Nodes.Remove(nodePendingPeers.Nodes.Cast<TreeNode>().Single(c => (Contact)c.Tag == contact)));
        }

        protected void ContactAdded(Contact contact)
        {
            this.BeginInvoke(() => nodePeers.Nodes.Add(contact.Protocol.Description).Tag = contact);
        }

        protected void ContactRemoved(Contact contact)
        {
            this.BeginInvoke(() => nodePeers.Nodes.Remove(nodePeers.Nodes.Cast<TreeNode>().Single(c => (Contact)c.Tag == contact)));
        }

        protected void OriginatorStoreAdded(BigInteger key)
        {
            this.BeginInvoke(() => nodeLocalStore.Nodes.Add(key.Prefix(VISIBLE_KEY_LENGTH)).Tag = key);
        }

        protected void RepublishStoreAdded(BigInteger key)
        {
            this.BeginInvoke(() => nodeRepublishStore.Nodes.Add(key.Prefix(VISIBLE_KEY_LENGTH)).Tag = key);
        }

        protected void RepublishStoreRemoved(BigInteger key)
        {
            this.BeginInvoke(() => nodeRepublishStore.Nodes.Remove(nodePeers.Nodes.Cast<TreeNode>().Single(c => (BigInteger)c.Tag == key)));
        }

        protected void CacheStoreAdded(BigInteger key)
        {
            this.BeginInvoke(() => nodeCacheStore.Nodes.Add(key.Prefix(VISIBLE_KEY_LENGTH)).Tag = key);
        }

        protected void CacheStoreRemoved(BigInteger key)
        {
            this.BeginInvoke(() => nodeCacheStore.Nodes.Remove(nodePeers.Nodes.Cast<TreeNode>().Single(c => (BigInteger)c.Tag == key)));
        }

        protected void RefreshStatus()
        {
            int peers = dht.Node.BucketList.Buckets.Sum(b => b.Contacts.Count);
            tbPeers.Text = peers.ToString();
            tbPendingPeers.Text = dht.PendingPeersCount.ToString();
            tbPendingEviction.Text = dht.PendingEvictionCount.ToString();
            tbOriginatingStore.Text = dht.OriginatorStorage.Keys.Count.ToString();
            tbRepublishStore.Text = dht.RepublishStorage.Keys.Count.ToString();
            tbCacheStore.Text = dht.CacheStorage.Keys.Count.ToString();
        }

        protected void PopulatePeerNodes()
        {
            dht.Node.BucketList.Buckets.ForEach(b => b.Contacts.ForEach(c => nodePeers.Nodes.Add(c.Protocol.Description)));
        }

        protected void PopulateStorageNodes()
        {
            dht.OriginatorStorage.Keys.ForEach(k =>
            {
                nodeLocalStore.Nodes.Add(k.Prefix(VISIBLE_KEY_LENGTH)).Tag = k;
            });

            dht.RepublishStorage.Keys.ForEach(k =>
            {
                nodeRepublishStore.Nodes.Add(k.Prefix(VISIBLE_KEY_LENGTH)).Tag = k;
            });

            dht.CacheStorage.Keys.ForEach(k =>
            {
                nodeCacheStore.Nodes.Add(k.Prefix(VISIBLE_KEY_LENGTH)).Tag = k;
            });
        }

        protected void SaveDht()
        {
            File.WriteAllText(Program.DHT_FILENAME, dht.Save());
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            SaveDht();
            Close();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            dht.Store(ID.FromString(tbStoreKey.Text), tbStoreValue.Text);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            var ret = dht.FindValue(ID.FromString(tbRetrieveKey.Text));

            if (ret.found)
            {
                tbRetrieveValue.Text = ret.val;
            }
            else
            {
                tbRetrieveValue.Text = String.Empty;
                MessageBox.Show("Key not found", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            IProtocol protocol = new TcpProtocol(tbOtherPeerUrl.Text, tbOtherPeerPort.Text.to_i());
            RpcError err = protocol.Ping(dht.Contact);

            if (err.HasError)
            {
                MessageBox.Show("Peer error: " + err.PeerErrorMessage + "\r\n" +
                    "Protocol error: " + err.ProtocolErrorMessage + "\r\n" +
                    "Timeout: " + err.TimeoutError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuStartDht_Click(object sender, EventArgs e)
        {

        }
    }
}
