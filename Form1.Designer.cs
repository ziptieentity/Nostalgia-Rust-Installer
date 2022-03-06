namespace NRInstaller
{
    partial class NRInstaller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NRInstaller));
            this.installClient = new System.Windows.Forms.Button();
            this.clientPath = new System.Windows.Forms.FolderBrowserDialog();
            this.server = new System.Windows.Forms.Button();
            this.serverPath = new System.Windows.Forms.FolderBrowserDialog();
            this.client = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.installServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // installClient
            // 
            this.installClient.Enabled = false;
            this.installClient.Location = new System.Drawing.Point(16, 58);
            this.installClient.Name = "installClient";
            this.installClient.Size = new System.Drawing.Size(227, 25);
            this.installClient.TabIndex = 0;
            this.installClient.Text = "Install Client";
            this.installClient.UseVisualStyleBackColor = true;
            this.installClient.Click += new System.EventHandler(this.installClient_Click);
            // 
            // clientPath
            // 
            this.clientPath.Description = "Client Install Location";
            this.clientPath.UseDescriptionForTitle = true;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(16, 121);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(227, 25);
            this.server.TabIndex = 1;
            this.server.Text = "Select Server Install Location";
            this.server.UseVisualStyleBackColor = true;
            this.server.Click += new System.EventHandler(this.server_Click);
            // 
            // serverPath
            // 
            this.serverPath.Description = "Server Install Location";
            this.serverPath.UseDescriptionForTitle = true;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(16, 12);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(227, 25);
            this.client.TabIndex = 2;
            this.client.Text = "Select Client Install Location";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Install Location: ";
            // 
            // installServer
            // 
            this.installServer.Enabled = false;
            this.installServer.Location = new System.Drawing.Point(16, 167);
            this.installServer.Name = "installServer";
            this.installServer.Size = new System.Drawing.Size(227, 25);
            this.installServer.TabIndex = 4;
            this.installServer.Text = "Install Server";
            this.installServer.UseVisualStyleBackColor = true;
            this.installServer.Click += new System.EventHandler(this.installServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Install Location: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-9, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 5);
            this.panel1.TabIndex = 6;
            // 
            // NRInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.installServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client);
            this.Controls.Add(this.server);
            this.Controls.Add(this.installClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NRInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NostalgiaRust Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button installClient;
        private FolderBrowserDialog clientPath;
        private Button server;
        private FolderBrowserDialog serverPath;
        private Button client;
        private Label label1;
        private Button installServer;
        private Label label2;
        private Panel panel1;
    }
}