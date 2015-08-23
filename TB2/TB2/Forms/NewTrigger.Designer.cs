namespace TB2.Forms
{
    partial class NewTrigger
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RBAfter = new System.Windows.Forms.RadioButton();
            this.RBBefore = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
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
            this.BTOK.Location = new System.Drawing.Point(397, 373);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(75, 23);
            this.BTOK.TabIndex = 8;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(478, 373);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 7;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 351);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.RBAfter);
            this.tabPage1.Controls.Add(this.RBBefore);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TBTableName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TBName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.comboBox1.Location = new System.Drawing.Point(141, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Event";
            // 
            // RBAfter
            // 
            this.RBAfter.AutoSize = true;
            this.RBAfter.Location = new System.Drawing.Point(261, 121);
            this.RBAfter.Name = "RBAfter";
            this.RBAfter.Size = new System.Drawing.Size(59, 21);
            this.RBAfter.TabIndex = 8;
            this.RBAfter.TabStop = true;
            this.RBAfter.Text = "After";
            this.RBAfter.UseVisualStyleBackColor = true;
            this.RBAfter.Click += new System.EventHandler(this.RBAfter_Click);
            // 
            // RBBefore
            // 
            this.RBBefore.AutoSize = true;
            this.RBBefore.Location = new System.Drawing.Point(141, 121);
            this.RBBefore.Name = "RBBefore";
            this.RBBefore.Size = new System.Drawing.Size(71, 21);
            this.RBBefore.TabIndex = 7;
            this.RBBefore.TabStop = true;
            this.RBBefore.Text = "Before";
            this.RBBefore.UseVisualStyleBackColor = true;
            this.RBBefore.Click += new System.EventHandler(this.RBBefore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
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
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(141, 27);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(225, 22);
            this.TBName.TabIndex = 1;
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
            this.Editbox.Location = new System.Drawing.Point(7, 6);
            this.Editbox.Name = "Editbox";
            this.Editbox.Size = new System.Drawing.Size(541, 310);
            this.Editbox.TabIndex = 0;
            this.Editbox.UseTabs = false;
            this.Editbox.Zoom = 1;
            // 
            // NewTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 405);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewTrigger";
            this.Text = "NewTrigger";
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
        private System.Windows.Forms.RadioButton RBAfter;
        private System.Windows.Forms.RadioButton RBBefore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private ScintillaNET.Scintilla Editbox;
    }
}