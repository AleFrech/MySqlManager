using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TB2.Entities;

namespace TB2.Controllers
{
    public  class ConnectionManager
    {
        public User CurrentUser;
        public string ConnectionString;
        public MySqlConnection MySqlConnection;

          
        public ConnectionManager(string connectionstring)
        {
            CurrentUser = new User();
                     
            ConnectionString = connectionstring;
        }


        public ConnectionString ConnectionStatus()
        {
            var status= new ConnectionString();
            status.Connection = ConnectionString;
            try
            {
               MySqlConnection = new MySqlConnection(ConnectionString);
               MySqlConnection.Open();
               status.message = "Succsesfull Connection";
               status.Confirmation = true;
               MySqlConnection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.message = ex.Message;
                status.Confirmation = false;
            }
          
            return status;
        }


        public void Userinfo(string username, string password, string database, string server)
        {
            CurrentUser.Username = username;
            CurrentUser.Password = password;
            CurrentUser.Database = database;
            CurrentUser.Server = server;
        }

        public void OpenConnection()
        {
            MySqlConnection.Open();
        }

        public void CloseConnection()
        {
            MySqlConnection.Close();
        }

        public void SetConnectionstring(string sstr)
        {
            try
            {
                var str2 = ConnectionString;
                ConnectionString = sstr;
                if (!ConnectionStatus().Confirmation)
                {
                    ConnectionString = str2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
           
     
    }
}
