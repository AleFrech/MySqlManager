using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TB2.Controllers
{
    public class ToolManager
    {
        public bool SuccessQuery;
        public string Errormessage;
        public DataTable MySqlQuery(UserManager currentUserrData, String Query)
        {
            var datatable = new DataTable();
            currentUserrData.Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandTimeout = 200;
            mySqlCommand.CommandText = Query;
            mySqlCommand.Connection = currentUserrData.Connection.MySqlConnection;
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
               
                if (mySqlReader.HasRows)
                {

                    datatable.Load(mySqlReader);
                    mySqlReader.Close();
                }
                SuccessQuery = true;
            }
            catch (Exception e)
            {
                    Errormessage = e.Message;
                    MessageBox.Show(e.Message);
                    SuccessQuery = false;
                
            }
            currentUserrData.Connection.MySqlConnection.Close();
            return datatable;

        }
        public bool CheckquerySyntax(UserManager currentUserrData, String Query)
        {
            var datatable= new DataTable();
            currentUserrData.Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandTimeout = 200;
            mySqlCommand.CommandText = Query;
            mySqlCommand.Connection = currentUserrData.Connection.MySqlConnection;
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();

                if (mySqlReader.HasRows)
                {

                    datatable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception e)
            {
                if (!e.Message.EndsWith("exists"))
                {
                    currentUserrData.Connection.MySqlConnection.Close();
                    return false;
                }

            }

            currentUserrData.Connection.MySqlConnection.Close();
            return true;

        }
    }
}
