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

namespace TB2
{
    public partial class LoginUser : Form
    {
        public string connect;
        public bool SuccesLogin;
        public LoginUser()
        {
            InitializeComponent();
        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTConnect_Click(object sender, EventArgs e)
        {
            if (TBUser.Text.Length == 0 || TBPass.Text.Length == 0)
            {
                MessageBox.Show(@"Empty Fields are not allowed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                connect = "SERVER=" + TBServer.Text + ";UID=" + this.TBUser.Text + ";PASSWORD=" + this.TBPass.Text + ";database=" + this.TBDatabase.Text + ";" + "Allow User Variables=True;";
                var mysqltest = new MySqlConnection(connect);
                mysqltest.Open();
                SuccesLogin = true;
                mysqltest.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SuccesLogin = false;
                return;
            }
            this.Hide();
        }

     
 
    }
}
