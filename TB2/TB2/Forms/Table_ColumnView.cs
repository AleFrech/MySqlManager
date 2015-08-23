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
    public partial class Table_ColumnView : Form
    {
        public string Objectname;
        private ToolManager tool = new ToolManager();
        private UserManager user;
        private bool edited;
        private ReservedList Words = new ReservedList();
        public Table_ColumnView(UserManager user)
        {
            this.user = user;
            edited = false;
            InitializeComponent();
            Editbox.Lexer = Lexer.Sql;
            Editbox.Margins[0].Width = 20;
            Editbox.Styles[ScintillaNET.Style.Sql.Number].ForeColor = Color.DarkOrange;
            Editbox.Styles[ScintillaNET.Style.Sql.String].ForeColor = Color.SaddleBrown;
            Editbox.Styles[ScintillaNET.Style.Sql.Character].ForeColor = Color.LimeGreen;
            Editbox.Styles[ScintillaNET.Style.Sql.Word].ForeColor = Color.Blue;
            Editbox.Styles[ScintillaNET.Style.Sql.Word2].ForeColor = Color.Blue;
            Editbox.SetKeywords(0, Words.Reserved1);
            Editbox.SetKeywords(1, Words.Reserved2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(2))
            {
                if (Editbox.Text.Length == 0)
                    return;
               
                Editbox.Enabled = false;
            }
        }


 

 
    }
}
