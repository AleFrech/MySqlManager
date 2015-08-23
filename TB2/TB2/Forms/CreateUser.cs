using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TB2.Controllers;

namespace TB2.Forms
{
    public partial class CreateUser : Form
    {
        private UserManager Usermanager;
        private ToolManager ToolManager;
        public CreateUser()
        {
            InitializeComponent();
        }

        public CreateUser(UserManager user,ToolManager tool)
        {
            InitializeComponent();
            Usermanager = user;
            ToolManager = tool;
        }

        private void BTCreate_Click(object sender, EventArgs e)
        {
            if (TBUserName.Text.Length == 0 || TBPass.Text.Length == 0 || TBConfirmPass.Text.Length == 0)
            {

                MessageBox.Show(@"Empty Fields are not allowed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TBPass.Text.Equals(TBConfirmPass.Text))
            {
                MessageBox.Show(@"Password & Confirm Password are not the same", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
                var usersql = "CREATE USER '"+ TBUserName.Text +"' IDENTIFIED BY '"+TBPass.Text+"';";
                ToolManager.MySqlQuery(Usermanager, usersql);
                var userprivigiles="GRANT CREATE,DROP,GRANT OPTION ,LOCK TABLES ,REFERENCES, EVENT ,ALTER ,DELETE ,INDEX ,INSERT ,SELECT ,UPDATE ,CREATE TEMPORARY TABLES,TRIGGER ,CREATE VIEW,SHOW VIEW,ALTER ROUTINE,CREATE ROUTINE  ON *.* TO "+TBUserName.Text;
                ToolManager.MySqlQuery(Usermanager, userprivigiles);

            if (ToolManager.SuccessQuery)
            {

                MessageBox.Show(@"User Created Succesfully", "Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Hide();
            }


        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
