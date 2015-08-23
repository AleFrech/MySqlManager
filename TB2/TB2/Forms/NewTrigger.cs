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
    public partial class NewTrigger : Form
    {
        private ToolManager Tool;
        private UserManager User;
        private string triggertime;
        private ReservedList Words = new ReservedList();
        public NewTrigger()
        {
            InitializeComponent();
        }
          public NewTrigger(ToolManager tool, UserManager usermanager)
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
            this.RBBefore.Checked = true;
            this.comboBox1.Text = comboBox1.Items[0].ToString();
            this.Editbox.Text = "CREATE TRIGGER 'trigger_name' 'trigger_time'" + "\n" + "'trigger_event' ON table_name FOR EACH ROW" +
              "\n" +
              "BEGIN" + "\n" + "END";
        }

          private void BTCancel_Click(object sender, EventArgs e)
          {
              this.Close();
          }

          private void RBBefore_Click(object sender, EventArgs e)
          {
              this.RBBefore.Checked = true;
              this.RBAfter.Checked = false;
          }

          private void RBAfter_Click(object sender, EventArgs e)
          {
              this.RBBefore.Checked = false;
              this.RBAfter.Checked = true;
          }

        

          private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (tabControl1.SelectedIndex == 1)
              {
                  if (this.TBName.Text.Length == 0 || this.TBTableName.Text.Length == 0)
                      return;

                  if (this.RBBefore.Checked)
                      triggertime = "BEFORE";
                  if (this.RBAfter.Checked)
                      triggertime = "AFTER";

                  var triggerevent = comboBox1.SelectedItem.ToString();

                  Editbox.Text = "CREATE TRIGGER " + TBName.Text + " " + triggertime + "\n" + triggerevent + " ON " + TBTableName.Text + " FOR EACH ROW" +
              "\n" +
              "BEGIN" + "\n" + "END";
                  this.BTOK.Enabled = true;

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
                  MessageBox.Show("Trigger Sucessfully Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.Close();
              }
          }

        
    }
}
