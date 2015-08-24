using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.ExtendedProperties;
using ScintillaNET;
using TB2.Controllers;
using TB2.Entities;

namespace TB2.Forms
{
    public partial class DDLView : Form
    {
        public string Object;
        public string Objectname;
        private ToolManager tool=new ToolManager();
        private UserManager user;
        private ReservedList Words = new ReservedList();
        public string tableindex;
        private string current;

        public DDLView(UserManager user,string text)
        {
            this.user = user;
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
            Editbox.Text = text;
            current = text;
            button1.Show();
            button2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (!current.Equals(Editbox.Text))
                {
                    if (Object.Equals("Index") && tableindex != null)
                    {
                        tool.MySqlQuery(user, "Drop " + Object + " " + Objectname + " ON " + tableindex + "");
                    }
                    else
                    {
                        if (tool.CheckquerySyntax(user, Editbox.Text))
                        {
                            tool.MySqlQuery(user, "Drop " + Object + " " + Objectname);
                        }
                    }

                    tool.MySqlQuery(user, Editbox.Text);
                    if (tool.SuccessQuery)
                    {
                        MessageBox.Show(Object + " Sucessfully Changed", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();

                    }
                }
            }
            this.Close();

        }


        private void mainTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
