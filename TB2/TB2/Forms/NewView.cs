using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.ExtendedProperties;
using ScintillaNET;
using TB2.Controllers;
using TB2.Entities;

namespace TB2.Forms
{
    public partial class NewView : Form
    {
        private ToolManager Tool;
        private UserManager User;
        private ReservedList Words = new ReservedList();
        private string sql;
        public NewView()
        {
            InitializeComponent();

        }
           public NewView(ToolManager tool, UserManager usermanager)
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
            this.Editbox.Text = "CREATE VIEW 'new_view' AS" + "\n";
        }

           private void BTCancel_Click(object sender, EventArgs e)
           {
               this.Close();
           }

           private void BTOK_Click(object sender, EventArgs e)
           {
               if (this.TBName.Text.Length == 0)
               {
                this.Editbox.Text = "CREATE VIEW 'new_view' AS" + "\n";
                return;
               }

               DataTable QueryResult;
               QueryResult = Tool.MySqlQuery(User, Editbox.Text);
               if (Tool.SuccessQuery)
               {
                   MessageBox.Show("View Sucessfully Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.Close();
               }
           }

           private void TBName_TextChanged(object sender, EventArgs e)
           {
               if (TBName.Text.Length == 0)
                   return;
               this.Editbox.Text = "CREATE VIEW " + TBName.Text + " AS"+"\n";
           }
    }
}
