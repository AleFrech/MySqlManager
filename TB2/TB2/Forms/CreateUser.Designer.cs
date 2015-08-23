namespace TB2.Forms
{
    partial class CreateUser
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
            this.LBUser = new System.Windows.Forms.Label();
            this.LBPass = new System.Windows.Forms.Label();
            this.LBConfirmPass = new System.Windows.Forms.Label();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBConfirmPass = new System.Windows.Forms.TextBox();
            this.BTCreate = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Location = new System.Drawing.Point(71, 52);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(75, 17);
            this.LBUser.TabIndex = 0;
            this.LBUser.Text = "UserName";
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.Location = new System.Drawing.Point(71, 89);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(69, 17);
            this.LBPass.TabIndex = 1;
            this.LBPass.Text = "Password";
            // 
            // LBConfirmPass
            // 
            this.LBConfirmPass.AutoSize = true;
            this.LBConfirmPass.Location = new System.Drawing.Point(71, 130);
            this.LBConfirmPass.Name = "LBConfirmPass";
            this.LBConfirmPass.Size = new System.Drawing.Size(121, 17);
            this.LBConfirmPass.TabIndex = 2;
            this.LBConfirmPass.Text = "Confirm Password";
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(214, 52);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(167, 22);
            this.TBUserName.TabIndex = 3;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(214, 89);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(167, 22);
            this.TBPass.TabIndex = 4;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // TBConfirmPass
            // 
            this.TBConfirmPass.Location = new System.Drawing.Point(214, 127);
            this.TBConfirmPass.Name = "TBConfirmPass";
            this.TBConfirmPass.Size = new System.Drawing.Size(167, 22);
            this.TBConfirmPass.TabIndex = 5;
            this.TBConfirmPass.UseSystemPasswordChar = true;
            // 
            // BTCreate
            // 
            this.BTCreate.Location = new System.Drawing.Point(83, 191);
            this.BTCreate.Name = "BTCreate";
            this.BTCreate.Size = new System.Drawing.Size(96, 31);
            this.BTCreate.TabIndex = 6;
            this.BTCreate.Text = "Create";
            this.BTCreate.UseVisualStyleBackColor = true;
            this.BTCreate.Click += new System.EventHandler(this.BTCreate_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(261, 191);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(96, 31);
            this.BTCancel.TabIndex = 7;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(454, 265);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTCreate);
            this.Controls.Add(this.TBConfirmPass);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.LBConfirmPass);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.LBUser);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.Label LBConfirmPass;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBConfirmPass;
        private System.Windows.Forms.Button BTCreate;
        private System.Windows.Forms.Button BTCancel;
    }
}