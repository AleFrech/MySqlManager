using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using TB2.Forms;

namespace TB2.Controllers
{
    public class UserManager
    {
        public ConnectionManager Connection;
  

        public UserManager(ConnectionManager connection)
        {
            this.Connection = connection;

        }
        public DataTable GetDataBases()
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("select schema_name from information_schema.schemata;", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }

        public DataTable GetUsers()
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("select user from mysql.user;", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }
 
        public  DataTable GetTables(string dbname)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE!='VIEW' AND table_schema ='" + dbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }

        public DataTable GetFunctions(string dbname)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE='FUNCTION' AND ROUTINE_SCHEMA='" + dbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);       
                    mySqlReader.Close();      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }
        public DataTable GetProcedure(string dbname)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE='PROCEDURE' AND ROUTINE_SCHEMA='" + dbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }
        public DataTable GetView(string dbname)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_SCHEMA='" + dbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }

        public DataTable GetColumnOfTable(string tbname)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name ='" + tbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
        }

        public DataTable GetTrigger(string tbname)
        {

           var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT TRIGGER_NAME FROM INFORMATION_SCHEMA.TRIGGERS WHERE EVENT_OBJECT_TABLE='" + tbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;
              
          
        }

        public DataTable GetIndex(string tbname)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT INDEX_NAME FROM INFORMATION_SCHEMA.STATISTICS WHERE TABLE_NAME='" + tbname + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            return dataTable;           
        }

        public void ShowProccedureDDL( TreeView treeView1)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT  param_list,body  FROM mysql.proc WHERE NAME='" + treeView1.SelectedNode.Text + "' and db = '" + Connection.CurrentUser.Database + "' and type ='PROCEDURE';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Connection.MySqlConnection.Close();
           
            var sql = "CREATE DEFINER='" + Connection.CurrentUser.Username + "'@'" + Connection.CurrentUser.Server +
                      "' PROCEDURE " + treeView1.SelectedNode.Text + "\n (" + Encoding.UTF8.GetString((byte[])dataTable.Rows[0][0]) + ")\n ";

            sql +=Encoding.UTF8.GetString((byte[])dataTable.Rows[0][1]) + "\n";
            var form = new DDLView(new UserManager(Connection),sql);
            form.Object = "PROCEDURE";
            form.Objectname = treeView1.SelectedNode.Text;
            form.Show();
        }

        public void ShowFunctionDDL(TreeView treeView1)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT  param_list,returns,body  FROM mysql.proc WHERE NAME='" + treeView1.SelectedNode.Text + "' and db = '" + Connection.CurrentUser.Database + "' and type ='FUNCTION';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Connection.MySqlConnection.Close();
          
            var sql = "CREATE DEFINER='" + Connection.CurrentUser.Username + "'@'" + Connection.CurrentUser.Server +
                      "' FUNCTION " + treeView1.SelectedNode.Text + "\n (" +Encoding.UTF8.GetString((byte[])dataTable.Rows[0][0])+ ")\n ";

            sql += "RETURNS " + Encoding.UTF8.GetString((byte[])dataTable.Rows[0][1]) + "\n";
            sql += Encoding.UTF8.GetString((byte[])dataTable.Rows[0][2]);


            var form = new DDLView(new UserManager(Connection),sql);
            form.Object = "FUNCTION";
            form.Objectname = treeView1.SelectedNode.Text;
            form.Show();
        }

        public void ShowViewDDL(TreeView treeView1)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT VIEW_DEFINITION FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_SCHEMA = '"+Connection.CurrentUser.Database+"' AND TABLE_NAME = '"+treeView1.SelectedNode.Text+"';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Connection.MySqlConnection.Close();
           
            var sql = "CREATE ALGORITHM=UNDEFINED DEFINER='" + Connection.CurrentUser.Username + "'@'" +
                      Connection.CurrentUser.Server + "'";
            sql += " SQL SECURITY DEFINER VIEW "+treeView1.SelectedNode.Text;
            sql += " AS " + dataTable.Rows[0][0].ToString();
            var form = new DDLView(new UserManager(Connection),sql);
            form.Object = "View";
            form.Objectname = treeView1.SelectedNode.Text;
            form.Show();
        }

        public void ShowTriggerDDL(TreeView treeView1)
        {
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT ACTION_TIMING,EVENT_MANIPULATION,EVENT_OBJECT_TABLE,ACTION_STATEMENT FROM INFORMATION_SCHEMA.TRIGGERS WHERE TRIGGER_SCHEMA='"+Connection.CurrentUser.Database+"' And TRIGGER_NAME='" + treeView1.SelectedNode.Text + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Connection.MySqlConnection.Close();
           
            var sql = "CREATE DEFINER='" + Connection.CurrentUser.Username + "'@'" + Connection.CurrentUser.Server +
                      "' TRIGGER";
            sql+=" "+Connection.CurrentUser.Database+"."+treeView1.SelectedNode.Text;
            sql += " "+dataTable.Rows[0][0].ToString();
            sql += " " + dataTable.Rows[0][1].ToString()+" ON";
            sql += " " + dataTable.Rows[0][2].ToString() + " FOR EACH ROW\n";
            sql += " " + dataTable.Rows[0][3].ToString();
            var form = new DDLView(new UserManager(Connection),sql);
            form.Object = "TRIGGER";
            form.Objectname = treeView1.SelectedNode.Text;
            form.Show();
        }

        public void ShowTable_ColumnDDL(TreeView treeView1)
        {
            var datacolumn = new DataTable();
            var dataData = new DataTable();
            var dataDDL = new DataTable();

            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT COLUMN_KEY ,COLUMN_NAME,IS_NULLABLE,DATA_TYPE,COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE Table_Name='" + treeView1.SelectedNode.Text + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    datacolumn.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Connection.MySqlConnection.Close();
            var form = new Table_ColumnView(new UserManager(Connection));
            form.dataGridViewColumns.DataSource = datacolumn;
            mySqlCommand = new MySqlCommand("SELECT * FROM " + treeView1.SelectedNode.Text + ";", Connection.MySqlConnection);
            Connection.MySqlConnection.Open();
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataData.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            form.dataGridViewData.DataSource = dataData;
            mySqlCommand = new MySqlCommand("SELECT COLUMN_KEY,COLUMN_NAME,COLUMN_TYPE,IS_NULLABLE,EXTRA FROM INFORMATION_SCHEMA.COLUMNS WHERE Table_Name='" + treeView1.SelectedNode.Text + "';", Connection.MySqlConnection);
            Connection.MySqlConnection.Open();
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataDDL.Load(mySqlReader);
                    mySqlReader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.MySqlConnection.Close();
            var sql = "CREATE TABLE " + treeView1.SelectedNode.Text + " (\n";

            for (int i = 0; i < dataDDL.Rows.Count; i++)
            {


                sql += " " + dataDDL.Rows[i][1] + " " + dataDDL.Rows[i][2] + " ";
                if (dataDDL.Rows[i][3].Equals("YES"))
                    sql += "DEFAULT NULL ";
                else
                {
                    sql += "NOT NULL ";
                }
                if (dataDDL.Rows[i][4].Equals("auto_increment"))
                    sql += " AUTO_INCREMENT";
                sql += ",\n";

            }
            var primarykeys = " PRIMARY KEY (";
            for (int i = 0; i < dataDDL.Rows.Count; i++)
            {

                if (dataDDL.Rows[i][0].Equals("PRI"))
                {
                    if (i != 0) primarykeys += ",";
                    primarykeys += "" + dataDDL.Rows[i][1] + "";

                }
            }
            sql += primarykeys + ")\n";
            sql += ")";
            form.Objectname = treeView1.SelectedNode.Text;
            form.Editbox.Text = sql;
            form.Show();
        }

        public void ShowIndexDDL(TreeView treeView1)
        {
            Console.WriteLine("am a Index");
            var dataTable = new DataTable();
            Connection.MySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT NON_UNIQUE,TABLE_NAME,COLUMN_NAME,INDEX_TYPE FROM  INFORMATION_SCHEMA.STATISTICS WHERE INDEX_SCHEMA='"+Connection.CurrentUser.Database+"' AND INDEX_NAME='" + treeView1.SelectedNode.Text + "';", Connection.MySqlConnection);
            MySqlDataReader mySqlReader;
            try
            {
                mySqlReader = mySqlCommand.ExecuteReader();
                if (mySqlReader.HasRows)
                {
                    dataTable.Load(mySqlReader);
                    mySqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Connection.MySqlConnection.Close();
          
            var sql = " ";
            if(dataTable.Rows[0][0].ToString().Equals("0"))

                 sql = "CREATE UNIQUE INDEX";
            else
            {
                sql = "CREATE INDEX";
            }
            sql += " " + treeView1.SelectedNode.Text+"\n";
            sql += "ON " + dataTable.Rows[0][1].ToString();
            sql+="("+dataTable.Rows[0][2]+")\n";
            sql += "USING " + dataTable.Rows[0][3].ToString();
            var form = new DDLView(new UserManager(Connection),sql);
            form.Object = "Index";
            form.Objectname = treeView1.SelectedNode.Text;
            form.tableindex = treeView1.SelectedNode.Parent.Parent.Text;
            form.Show();

        }


    }
}
