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
    public partial class NewProcedure : Form
    {
        private ToolManager Tool;
        private UserManager User;
        private string sql;
        private ReservedList Words = new ReservedList();
        public NewProcedure()
        {
            InitializeComponent();
        }

        public NewProcedure(ToolManager tool, UserManager usermanager)
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
            this.Editbox.Text = "CREATE PROCEDURE 'new_procedure' ()" +"\n"+
                                     "BEGIN" +"\n "+
                                     "END";
        }
   

        private void BTCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                this.BTOK.Enabled = true;
                sql = "CREATE PROCEDURE " + this.TBName.Text + " (";
                if (dataGridView1.Rows.Count > 1)
                {
                    
                    for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)
                    {
                        if (i != 0) sql += ",";
                        sql += dataGridView1.Rows[i].Cells["Type"].Value.ToString();
                        sql += " " + dataGridView1.Rows[i].Cells["Name"].Value.ToString();
                        sql += " " + dataGridView1.Rows[i].Cells["DataType"].Value.ToString();
                    }
                    sql+=") "+"\n"+"BEGIN "+"\n"+"END";
                    Editbox.Text = sql;
                }
                
            }
           
        }
        private void BTRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
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
                MessageBox.Show("Procedure Sucessfully Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

    }
}
