namespace TB2.Forms
{
    partial class NewView
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
            this.BTOK = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Editbox = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(342, 272);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(75, 23);
            this.BTOK.TabIndex = 10;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(423, 272);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 9;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(102, 31);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(225, 22);
            this.TBName.TabIndex = 8;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // Editbox
            // 
            this.Editbox.Location = new System.Drawing.Point(3, 59);
            this.Editbox.Name = "Editbox";
            this.Editbox.Size = new System.Drawing.Size(507, 207);
            this.Editbox.TabIndex = 11;
            this.Editbox.UseTabs = false;
            this.Editbox.Zoom = 1;
            // 
            // NewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 326);
            this.Controls.Add(this.Editbox);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label1);
            this.Name = "NewView";
            this.Text = "NewView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private ScintillaNET.Scintilla Editbox;
    }
}