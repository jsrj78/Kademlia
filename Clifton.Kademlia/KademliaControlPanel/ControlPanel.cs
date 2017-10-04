using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Clifton.Kademlia.Common;

namespace KademliaControlPanel
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void RefreshStatus()
        {
            int peers = Program.dht.Node.BucketList.Buckets.Sum(b => b.Contacts.Count);
            tbPeers.Text = peers.ToString();
            tbPendingPeers.Text = Program.dht.PendingPeersCount.ToString();
            tbPendingEviction.Text = Program.dht.PendingEvictionCount.ToString();
            tbOriginatingStore.Text = Program.localStore.Keys.Count.ToString();
            tbRepublishStore.Text = Program.republishStore.Keys.Count.ToString();
            tbCacheStore.Text = Program.cacheStore.Keys.Count.ToString();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Program.DHT_FILENAME, Program.dht.Save());
            Close();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            Program.dht.Store(ID.FromString(tbStoreKey.Text), tbStoreValue.Text);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            var ret = Program.dht.FindValue(ID.FromString(tbRetrieveKey.Text));

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }
    }
}
