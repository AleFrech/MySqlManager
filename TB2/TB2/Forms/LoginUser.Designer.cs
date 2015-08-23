namespace TB2
{
    partial class LoginUser
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
            this.BTConnect = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.LBUser = new System.Windows.Forms.Label();
            this.LBPass = new System.Windows.Forms.Label();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.LBServer = new System.Windows.Forms.Label();
            this.TBServer = new System.Windows.Forms.TextBox();
            this.LBDatabase = new System.Windows.Forms.Label();
            this.TBDatabase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTConnect
            // 
            this.BTConnect.Location = new System.Drawing.Point(105, 225);
            this.BTConnect.Name = "BTConnect";
            this.BTConnect.Size = new System.Drawing.Size(110, 31);
            this.BTConnect.TabIndex = 0;
            this.BTConnect.Text = "Connect";
            this.BTConnect.UseVisualStyleBackColor = true;
            this.BTConnect.Click += new System.EventHandler(this.BTConnect_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(257, 225);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(110, 31);
            this.BTCancel.TabIndex = 1;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Location = new System.Drawing.Point(106, 43);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(73, 17);
            this.LBUser.TabIndex = 2;
            this.LBUser.Text = "Username";
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.Location = new System.Drawing.Point(106, 87);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(69, 17);
            this.LBPass.TabIndex = 3;
            this.LBPass.Text = "Password";
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(257, 43);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(126, 22);
            this.TBUser.TabIndex = 4;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(257, 87);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(126, 22);
            this.TBPass.TabIndex = 5;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // LBServer
            // 
            this.LBServer.AutoSize = true;
            this.LBServer.Location = new System.Drawing.Point(106, 133);
            this.LBServer.Name = "LBServer";
            this.LBServer.Size = new System.Drawing.Size(50, 17);
            this.LBServer.TabIndex = 6;
            this.LBServer.Text = "Server";
            // 
            // TBServer
            // 
            this.TBServer.Location = new System.Drawing.Point(257, 133);
            this.TBServer.Name = "TBServer";
            this.TBServer.Size = new System.Drawing.Size(126, 22);
            this.TBServer.TabIndex = 7;
            this.TBServer.Text = "localhost";
            // 
            // LBDatabase
            // 
            this.LBDatabase.AutoSize = true;
            this.LBDatabase.Location = new System.Drawing.Point(106, 176);
            this.LBDatabase.Name = "LBDatabase";
            this.LBDatabase.Size = new System.Drawing.Size(69, 17);
            this.LBDatabase.TabIndex = 8;
            this.LBDatabase.Text = "Database";
            // 
            // TBDatabase
            // 
            this.TBDatabase.Location = new System.Drawing.Point(257, 176);
            this.TBDatabase.Name = "TBDatabase";
            this.TBDatabase.Size = new System.Drawing.Size(126, 22);
            this.TBDatabase.TabIndex = 9;
            this.TBDatabase.Text = "tb2";
            // 
            // LoginUser
            // 
            this.ClientSize = new System.Drawing.Size(494, 306);
            this.Controls.Add(this.TBDatabase);
            this.Controls.Add(this.LBDatabase);
            this.Controls.Add(this.TBServer);
            this.Controls.Add(this.LBServer);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTConnect);
            this.Name = "LoginUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTConnect;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.Label LBPass;
        public System.Windows.Forms.TextBox TBUser;
        public System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label LBServer;
        public System.Windows.Forms.TextBox TBServer;
        private System.Windows.Forms.Label LBDatabase;
        public System.Windows.Forms.TextBox TBDatabase;

      
    }
}