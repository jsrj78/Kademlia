namespace KademliaControlPanel
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbStore = new System.Windows.Forms.TabPage();
            this.btnStore = new System.Windows.Forms.Button();
            this.tbStoreValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStoreKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRetrieve = new System.Windows.Forms.TabPage();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.tbRetrieveValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRetrieveKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbCacheStore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRepublishStore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOriginatingStore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPendingEviction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPendingPeers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPeers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbStore.SuspendLayout();
            this.tbRetrieve.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbStore);
            this.tabControl1.Controls.Add(this.tbRetrieve);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(286, 116);
            this.tabControl1.TabIndex = 1;
            // 
            // tbStore
            // 
            this.tbStore.Controls.Add(this.btnStore);
            this.tbStore.Controls.Add(this.tbStoreValue);
            this.tbStore.Controls.Add(this.label2);
            this.tbStore.Controls.Add(this.tbStoreKey);
            this.tbStore.Controls.Add(this.label1);
            this.tbStore.Location = new System.Drawing.Point(4, 22);
            this.tbStore.Name = "tbStore";
            this.tbStore.Padding = new System.Windows.Forms.Padding(3);
            this.tbStore.Size = new System.Drawing.Size(278, 90);
            this.tbStore.TabIndex = 0;
            this.tbStore.Text = "Store";
            this.tbStore.UseVisualStyleBackColor = true;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(196, 60);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // tbStoreValue
            // 
            this.tbStoreValue.Location = new System.Drawing.Point(50, 34);
            this.tbStoreValue.Name = "tbStoreValue";
            this.tbStoreValue.Size = new System.Drawing.Size(221, 20);
            this.tbStoreValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value:";
            // 
            // tbStoreKey
            // 
            this.tbStoreKey.Location = new System.Drawing.Point(50, 8);
            this.tbStoreKey.Name = "tbStoreKey";
            this.tbStoreKey.Size = new System.Drawing.Size(221, 20);
            this.tbStoreKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // tbRetrieve
            // 
            this.tbRetrieve.Controls.Add(this.btnRetrieve);
            this.tbRetrieve.Controls.Add(this.tbRetrieveValue);
            this.tbRetrieve.Controls.Add(this.label3);
            this.tbRetrieve.Controls.Add(this.tbRetrieveKey);
            this.tbRetrieve.Controls.Add(this.label4);
            this.tbRetrieve.Location = new System.Drawing.Point(4, 22);
            this.tbRetrieve.Name = "tbRetrieve";
            this.tbRetrieve.Padding = new System.Windows.Forms.Padding(3);
            this.tbRetrieve.Size = new System.Drawing.Size(278, 90);
            this.tbRetrieve.TabIndex = 1;
            this.tbRetrieve.Text = "Retrieve";
            this.tbRetrieve.UseVisualStyleBackColor = true;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(196, 60);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 9;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // tbRetrieveValue
            // 
            this.tbRetrieveValue.Location = new System.Drawing.Point(50, 34);
            this.tbRetrieveValue.Name = "tbRetrieveValue";
            this.tbRetrieveValue.ReadOnly = true;
            this.tbRetrieveValue.Size = new System.Drawing.Size(221, 20);
            this.tbRetrieveValue.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Value:";
            // 
            // tbRetrieveKey
            // 
            this.tbRetrieveKey.Location = new System.Drawing.Point(50, 8);
            this.tbRetrieveKey.Name = "tbRetrieveKey";
            this.tbRetrieveKey.Size = new System.Drawing.Size(221, 20);
            this.tbRetrieveKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.tbCacheStore);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbRepublishStore);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbOriginatingStore);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbPendingEviction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPendingPeers);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPeers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(169, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh Now";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbCacheStore
            // 
            this.tbCacheStore.Location = new System.Drawing.Point(125, 181);
            this.tbCacheStore.Name = "tbCacheStore";
            this.tbCacheStore.ReadOnly = true;
            this.tbCacheStore.Size = new System.Drawing.Size(100, 20);
            this.tbCacheStore.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cache Store:";
            // 
            // tbRepublishStore
            // 
            this.tbRepublishStore.Location = new System.Drawing.Point(125, 155);
            this.tbRepublishStore.Name = "tbRepublishStore";
            this.tbRepublishStore.ReadOnly = true;
            this.tbRepublishStore.Size = new System.Drawing.Size(100, 20);
            this.tbRepublishStore.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Republish Store:";
            // 
            // tbOriginatingStore
            // 
            this.tbOriginatingStore.Location = new System.Drawing.Point(125, 129);
            this.tbOriginatingStore.Name = "tbOriginatingStore";
            this.tbOriginatingStore.ReadOnly = true;
            this.tbOriginatingStore.Size = new System.Drawing.Size(100, 20);
            this.tbOriginatingStore.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Originating Store:";
            // 
            // tbPendingEviction
            // 
            this.tbPendingEviction.Location = new System.Drawing.Point(125, 103);
            this.tbPendingEviction.Name = "tbPendingEviction";
            this.tbPendingEviction.ReadOnly = true;
            this.tbPendingEviction.Size = new System.Drawing.Size(100, 20);
            this.tbPendingEviction.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pending Eviction:";
            // 
            // tbPendingPeers
            // 
            this.tbPendingPeers.Location = new System.Drawing.Point(125, 77);
            this.tbPendingPeers.Name = "tbPendingPeers";
            this.tbPendingPeers.ReadOnly = true;
            this.tbPendingPeers.Size = new System.Drawing.Size(100, 20);
            this.tbPendingPeers.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pending Peers:";
            // 
            // tbPeers
            // 
            this.tbPeers.Location = new System.Drawing.Point(125, 51);
            this.tbPeers.Name = "tbPeers";
            this.tbPeers.ReadOnly = true;
            this.tbPeers.Size = new System.Drawing.Size(100, 20);
            this.tbPeers.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Peers:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPing);
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbUrl);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(306, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "URL:";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(62, 17);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(150, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "http://24.105.201.179";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(62, 43);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(84, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "3001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Port:";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(10, 81);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 4;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlPanel";
            this.Text = "Kademlia Control Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbStore.ResumeLayout(false);
            this.tbStore.PerformLayout();
            this.tbRetrieve.ResumeLayout(false);
            this.tbRetrieve.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbStore;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.TextBox tbStoreValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStoreKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbRetrieve;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.TextBox tbRetrieveValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRetrieveKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPendingPeers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPeers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbCacheStore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRepublishStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOriginatingStore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPendingEviction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label11;
    }
}

