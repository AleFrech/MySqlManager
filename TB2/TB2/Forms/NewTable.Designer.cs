namespace TB2.Forms
{
    partial class NewTable
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
            this.BTRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Editbox = new ScintillaNET.Scintilla();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Enabled = false;
            this.BTOK.Location = new System.Drawing.Point(540, 432);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(75, 23);
            this.BTOK.TabIndex = 5;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(621, 432);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 407);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTRemove);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.TBName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTRemove
            // 
            this.BTRemove.BackgroundImage = global::TB2.Properties.Resources.red_x;
            this.BTRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTRemove.Location = new System.Drawing.Point(667, 62);
            this.BTRemove.Name = "BTRemove";
            this.BTRemove.Size = new System.Drawing.Size(26, 23);
            this.BTRemove.TabIndex = 3;
            this.BTRemove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DataType,
            this.PK,
            this.NN,
            this.AI});
            this.dataGridView1.Location = new System.Drawing.Point(6, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Column Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // DataType
            // 
            this.DataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataType.HeaderText = "Data Type";
            this.DataType.Name = "DataType";
            // 
            // PK
            // 
            this.PK.HeaderText = "PK";
            this.PK.Name = "PK";
            // 
            // NN
            // 
            this.NN.HeaderText = "NN";
            this.NN.Name = "NN";
            // 
            // AI
            // 
            this.AI.HeaderText = "AI";
            this.AI.Name = "AI";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(90, 22);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(225, 22);
            this.TBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
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
            this.tabPage2.Size = new System.Drawing.Size(693, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Editbox
            // 
            this.Editbox.Location = new System.Drawing.Point(3, 6);
            this.Editbox.Name = "Editbox";
            this.Editbox.Size = new System.Drawing.Size(686, 366);
            this.Editbox.TabIndex = 0;
            this.Editbox.UseTabs = false;
            this.Editbox.Zoom = 1;
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 467);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewTable";
            this.Text = "NewTable";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BTRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AI;
        private ScintillaNET.Scintilla Editbox;
    }
}