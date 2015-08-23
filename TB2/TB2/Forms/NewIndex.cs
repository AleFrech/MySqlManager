using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using TB2.Controllers;

namespace TB2.Forms
{
    public partial class NewIndex : Form
    {
        private ToolManager Tool;
        private UserManager User;
        private string sql;
        private ReservedList Words = new ReservedList();
        public NewIndex()
        {
            InitializeComponent();
        }

        public NewIndex(ToolManager tool, UserManager usermanager)
        {
            Tool = tool;
            User = usermanager;

            InitializeComponent();
            Editbox.Lexer = Lexer.Sql;
            Editbox.Margins[0].Width = 20;
            Editbox.Styles[Style.Sql.Number].ForeColor = Color.DarkOrange;
            Editbox.Styles[Style.Sql.String].ForeColor = Color.SaddleBrown;
            Editbox.Styles[Style.Sql.Character].ForeColor = Color.LimeGreen;
            Editbox.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            Editbox.Styles[Style.Sql.Word2].ForeColor = Color.Blue;
            Editbox.SetKeywords(0, Words.Reserved1);
            Editbox.SetKeywords(1, Words.Reserved2);
            this.Editbox.Text = "CREATE INDEX 'your_index_name' " + "\n" +
                                     "ON 'your_table_name'('your_column_name')" + "\n" + "USING BTREE;";
            this.RBNonUnique.Checked = true;
        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBNonUnique_Click(object sender, EventArgs e)
        {
            this.RBNonUnique.Checked = true;
            this.RBUnique.Checked = false;
        }

        private void RBUnique_Click(object sender, EventArgs e)
        {
            this.RBNonUnique.Checked = false;
            this.RBUnique.Checked = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if(this.TBColumnName.Text.Length==0||this.TBIndexName.Text.Length==0||this.TBTableName.Text.Length==0)
                    return;

                if (this.RBUnique.Checked)
                    sql = "CREATE UNIQUE INDEX ";
                if(this.RBNonUnique.Checked)
                    sql = "CREATE INDEX ";

                sql +=""+ this.TBIndexName.Text +" \n" +
                                     "ON " + this.TBTableName.Text + "(" + this.TBColumnName.Text + ")" + "\n" + "USING BTREE;";
                this.BTOK.Enabled = true;
                Editbox.Text = sql;
            }
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (Editbox.Text.Length == 0)
                return;

            DataTable QueryResult;
            QueryResult = Tool.MySqlQuery(User,Editbox.Text);
            if (Tool.SuccessQuery)
            {
                MessageBox.Show("Index Sucessfully Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

  

   
    }
}
