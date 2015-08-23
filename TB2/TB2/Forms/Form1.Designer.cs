using System;
using System.Security.AccessControl;
using System.Windows.Forms;
using GvS.Controls;

namespace TB2
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTRefresh = new System.Windows.Forms.Button();
            this.BTTest = new System.Windows.Forms.Button();
            this.BT1 = new System.Windows.Forms.Button();
            this.LogRichtxb = new System.Windows.Forms.RichTextBox();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.Editbox = new ScintillaNET.Scintilla();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 79);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 437);
            this.treeView1.TabIndex = 2;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.schemaToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.triggerToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.procedureToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.vIewToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // schemaToolStripMenuItem
            // 
            this.schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            this.schemaToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.schemaToolStripMenuItem.Text = "Database";
            this.schemaToolStripMenuItem.Click += new System.EventHandler(this.schemaToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.triggerToolStripMenuItem.Text = "Trigger";
            this.triggerToolStripMenuItem.Click += new System.EventHandler(this.triggerToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.indexToolStripMenuItem.Text = "Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // procedureToolStripMenuItem
            // 
            this.procedureToolStripMenuItem.Name = "procedureToolStripMenuItem";
            this.procedureToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.procedureToolStripMenuItem.Text = "Procedure";
            this.procedureToolStripMenuItem.Click += new System.EventHandler(this.procedureToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.functionToolStripMenuItem.Text = "Function";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // vIewToolStripMenuItem
            // 
            this.vIewToolStripMenuItem.Name = "vIewToolStripMenuItem";
            this.vIewToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.vIewToolStripMenuItem.Text = "View";
            this.vIewToolStripMenuItem.Click += new System.EventHandler(this.vIewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // BTRefresh
            // 
            this.BTRefresh.BackgroundImage = global::TB2.Properties.Resources.refresh;
            this.BTRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTRefresh.Location = new System.Drawing.Point(25, 55);
            this.BTRefresh.Name = "BTRefresh";
            this.BTRefresh.Size = new System.Drawing.Size(28, 25);
            this.BTRefresh.TabIndex = 6;
            this.BTRefresh.UseVisualStyleBackColor = true;
            this.BTRefresh.Click += new System.EventHandler(this.BTRefresh_Click);
            // 
            // BTTest
            // 
            this.BTTest.AutoSize = true;
            this.BTTest.BackgroundImage = global::TB2.Properties.Resources.play;
            this.BTTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTTest.Location = new System.Drawing.Point(256, 55);
            this.BTTest.Name = "BTTest";
            this.BTTest.Size = new System.Drawing.Size(28, 26);
            this.BTTest.TabIndex = 5;
            this.BTTest.UseVisualStyleBackColor = true;
            this.BTTest.Click += new System.EventHandler(this.BTTest_Click);
            // 
            // BT1
            // 
            this.BT1.BackgroundImage = global::TB2.Properties.Resources.login;
            this.BT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT1.Location = new System.Drawing.Point(0, 55);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(28, 26);
            this.BT1.TabIndex = 0;
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // LogRichtxb
            // 
            this.LogRichtxb.Location = new System.Drawing.Point(256, 518);
            this.LogRichtxb.Name = "LogRichtxb";
            this.LogRichtxb.ReadOnly = true;
            this.LogRichtxb.Size = new System.Drawing.Size(824, 115);
            this.LogRichtxb.TabIndex = 10;
            this.LogRichtxb.Text = "";
            // 
            // scintilla1
            // 
            this.scintilla1.Location = new System.Drawing.Point(703, 220);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(8, 8);
            this.scintilla1.TabIndex = 11;
            this.scintilla1.Text = "scintilla1";
            this.scintilla1.UseTabs = false;
            // 
            // Editbox
            // 
            this.Editbox.Location = new System.Drawing.Point(256, 79);
            this.Editbox.Name = "Editbox";
            this.Editbox.Size = new System.Drawing.Size(824, 421);
            this.Editbox.TabIndex = 12;
            this.Editbox.UseTabs = false;
            this.Editbox.Zoom = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1092, 645);
            this.Controls.Add(this.Editbox);
            this.Controls.Add(this.scintilla1);
            this.Controls.Add(this.LogRichtxb);
            this.Controls.Add(this.BTRefresh);
            this.Controls.Add(this.BTTest);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MySql Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button BTTest;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem tableToolStripMenuItem;
        private ToolStripMenuItem triggerToolStripMenuItem;
        private ToolStripMenuItem procedureToolStripMenuItem;
        private ToolStripMenuItem functionToolStripMenuItem;
        private ToolStripMenuItem vIewToolStripMenuItem;
        private Button BTRefresh;
        private ToolStripMenuItem schemaToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private RichTextBox LogRichtxb;
        private ScintillaNET.Scintilla scintilla1;
        private ScintillaNET.Scintilla Editbox;
    }
}

