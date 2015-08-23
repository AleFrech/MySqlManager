namespace TB2.Forms
{
    partial class NewIndex
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RBUnique = new System.Windows.Forms.RadioButton();
            this.RBNonUnique = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TBColumnName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBIndexName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Editbox = new ScintillaNET.Scintilla();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Enabled = false;
            this.BTOK.Location = new System.Drawing.Point(398, 374);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(75, 23);
            this.BTOK.TabIndex = 5;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(479, 374);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 4;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 351);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RBUnique);
            this.tabPage1.Controls.Add(this.RBNonUnique);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TBColumnName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TBTableName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TBIndexName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RBUnique
            // 
            this.RBUnique.AutoSize = true;
            this.RBUnique.Location = new System.Drawing.Point(266, 157);
            this.RBUnique.Name = "RBUnique";
            this.RBUnique.Size = new System.Drawing.Size(74, 21);
            this.RBUnique.TabIndex = 8;
            this.RBUnique.TabStop = true;
            this.RBUnique.Text = "Unique";
            this.RBUnique.UseVisualStyleBackColor = true;
            this.RBUnique.Click += new System.EventHandler(this.RBUnique_Click);
            // 
            // RBNonUnique
            // 
            this.RBNonUnique.AutoSize = true;
            this.RBNonUnique.Location = new System.Drawing.Point(141, 157);
            this.RBNonUnique.Name = "RBNonUnique";
            this.RBNonUnique.Size = new System.Drawing.Size(100, 21);
            this.RBNonUnique.TabIndex = 7;
            this.RBNonUnique.TabStop = true;
            this.RBNonUnique.Text = "NonUnique";
            this.RBNonUnique.UseVisualStyleBackColor = true;
            this.RBNonUnique.Click += new System.EventHandler(this.RBNonUnique_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // TBColumnName
            // 
            this.TBColumnName.Location = new System.Drawing.Point(141, 110);
            this.TBColumnName.Name = "TBColumnName";
            this.TBColumnName.Size = new System.Drawing.Size(225, 22);
            this.TBColumnName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Column Name";
            // 
            // TBTableName
            // 
            this.TBTableName.Location = new System.Drawing.Point(141, 70);
            this.TBTableName.Name = "TBTableName";
            this.TBTableName.Size = new System.Drawing.Size(225, 22);
            this.TBTableName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Name";
            // 
            // TBIndexName
            // 
            this.TBIndexName.Location = new System.Drawing.Point(141, 27);
            this.TBIndexName.Name = "TBIndexName";
            this.TBIndexName.Size = new System.Drawing.Size(225, 22);
            this.TBIndexName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Editbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Editbox
            // 
            this.Editbox.Location = new System.Drawing.Point(6, 6);
            this.Editbox.Name = "Editbox";
            this.Editbox.Size = new System.Drawing.Size(542, 310);
            this.Editbox.TabIndex = 0;
            this.Editbox.UseTabs = false;
            this.Editbox.Zoom = 1;
            // 
            // NewIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 416);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewIndex";
            this.Text = "NewIndex";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TBIndexName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TBColumnName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBUnique;
        private System.Windows.Forms.RadioButton RBNonUnique;
        private System.Windows.Forms.Label label4;
        private ScintillaNET.Scintilla Editbox;
    }
}