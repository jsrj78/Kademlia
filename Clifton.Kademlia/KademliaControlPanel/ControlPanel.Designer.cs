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
            this.tbRetrieve = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStoreKey = new System.Windows.Forms.TextBox();
            this.tbStoreValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.tbRetrieveValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRetrieveKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbStore.SuspendLayout();
            this.tbRetrieve.SuspendLayout();
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
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // tbStoreKey
            // 
            this.tbStoreKey.Location = new System.Drawing.Point(50, 8);
            this.tbStoreKey.Name = "tbStoreKey";
            this.tbStoreKey.Size = new System.Drawing.Size(221, 20);
            this.tbStoreKey.TabIndex = 1;
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
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 445);
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
    }
}

