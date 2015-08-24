using System;
using System.Drawing;
using System.Windows.Forms;
using DocumentFormat.OpenXml.ExtendedProperties;
using MySql.Data.MySqlClient;
using ScintillaNET;
using TB2.Controllers;
using TB2.Forms;
using DataTable = System.Data.DataTable;

namespace TB2
{
    public partial class Form1 : Form
    {
        public UserManager Usermanager;
        public ToolManager tool = new ToolManager();
        private int currentTextinMailength=0;
        private ReservedList Words = new ReservedList();
        
        private string connect = "SERVER=localhost;UID=root;PASSWORD=zxcvbhjkl;";
        public Form1()
        {
           
            InitializeComponent();
            Usermanager = new UserManager(new ConnectionManager(connect));
            Console.WriteLine(Usermanager.Connection.ConnectionStatus().message);
            Editbox.Lexer = Lexer.Sql;
            Editbox.Margins[0].Width = 20;
            Editbox.Styles[Style.Sql.Number].ForeColor = Color.DarkOrange;
            Editbox.Styles[Style.Sql.String].ForeColor = Color.SaddleBrown;
            Editbox.Styles[Style.Sql.Character].ForeColor = Color.LimeGreen;
            Editbox.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            Editbox.Styles[Style.Sql.Word2].ForeColor = Color.Blue;
            Editbox.SetKeywords(0,Words.Reserved1);
            Editbox.SetKeywords(1,Words.Reserved2);


            LoadtreeDB();
          
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            var form = new LoginUser();
            form.ShowDialog();
            if(form.connect==null)
                return;
            Usermanager.Connection.MySqlConnection=new MySqlConnection(form.connect);
            if (Usermanager.Connection.ConnectionString!=null||Usermanager.Connection.ConnectionStatus().Confirmation)
            {
                if (form.SuccesLogin)
                {
                    Usermanager.Connection.Userinfo(form.TBUser.Text, form.TBPass.Text, form.TBDatabase.Text,
                        form.TBServer.Text);

                    for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
                    {
                        treeView1.Nodes[0].Nodes[i].Nodes.Clear();
                    }
                    if (treeView1.Nodes.Count>1)
                    {
                        
                            treeView1.Nodes[1].Remove();
                      
                    }
                    LoadTree();
                }
            }
            else          
            {
                Usermanager = new UserManager(new ConnectionManager(connect));
                Usermanager.Connection.ConnectionStatus();
            }

        }

        private void BTTest_Click(object sender, EventArgs e)
        {
            
            if (Editbox.Text.Length == 0)
                return;
            
            DataTable QueryResult;
            
            QueryResult=tool.MySqlQuery(Usermanager, Editbox.SelectedText);
            var form = new QueryResultForm();
            form.dataGridView1.DataSource = QueryResult;
            if (tool.SuccessQuery)
            {
                var tmp=DateTime.Now.ToString()+" Successful Query!!!\n";
                LogRichtxb.AppendText(tmp);
                LogRichtxb.Select(LogRichtxb.Text.IndexOf(tmp), tmp.Length);
                LogRichtxb.SelectionColor = Color.Black;
       
            }
            if (!tool.SuccessQuery)
            {
                var tmp = DateTime.Now.ToString() +tool.Errormessage+"\n";
                LogRichtxb.AppendText(tmp);
                LogRichtxb.Select(LogRichtxb.Text.IndexOf(tmp), tmp.Length);
                LogRichtxb.SelectionColor = Color.Red;
            }
          
            if(QueryResult.Rows.Count!=0)
            form.Show();
        }

        private void LoadtreeDB()
        {
            LoadImgtree();
            DataTable dataDatabases = Usermanager.GetDataBases();
            treeView1.Nodes.Add("Databases", "Databases", "Folder", "Folder");
            for (int i = 0; i < dataDatabases.Rows.Count; i++)
            {
                treeView1.Nodes[0].Nodes.Add(dataDatabases.Rows[i][0].ToString(), dataDatabases.Rows[i][0].ToString(),"DB","DB");
            }

            
        }
        private void LoadTree()
        {
            DataTable dataUsers=Usermanager.GetUsers();
            LoadImgtree();
            treeView1.Nodes.Add("Users", "Users", "Folder", "Folder");
            //for (int i = 0; i < dataBases.Rows.Count; i++)
            //{
            //    treeView1.Nodes[0].Nodes.Add(dataBases.Rows[i][0].ToString(), dataBases.Rows[i][0].ToString(), "DB", "DB");
                //load tables under database
                treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes.Add("Tables", "Tables", "Folder", "Folder");
                var dataTables = Usermanager.GetTables(Usermanager.Connection.CurrentUser.Database);
                for (int j = 0; j < dataTables.Rows.Count; j++)
                {
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes.Add(dataTables.Rows[j][0].ToString(), dataTables.Rows[j][0].ToString(), "Table", "Table");
                    //load column folder under table
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes[j].Nodes.Add("Columns", "Columns", "Folder", "Folder");
                    var dataColumns = Usermanager.GetColumnOfTable(dataTables.Rows[j][0].ToString());
                    for (int k = 0; k < dataColumns.Rows.Count; k++)
                    {
                        treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes[j].Nodes[0].Nodes.Add(dataColumns.Rows[k][0].ToString(), dataColumns.Rows[k][0].ToString(), "Column", "Column");
                    }
                    //load indexes floder under table
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes[j].Nodes.Add("Indexes", "Indexes", "Folder", "Folder");
                    var dataIndex = Usermanager.GetIndex(dataTables.Rows[j][0].ToString());
                    for (int idx = 0; idx < dataIndex.Rows.Count; idx++)
                    {
                        treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes[j].Nodes[1].Nodes.Add(dataIndex.Rows[idx][0].ToString(), dataIndex.Rows[idx][0].ToString(), "Index", "Index");
                    }
                    //load trigger folder under table
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes[j].Nodes.Add("Triggers", "Triggers", "Folder", "Folder");
                    var dataTrigers = Usermanager.GetTrigger(dataTables.Rows[j][0].ToString());
                    for (int trg = 0; trg < dataTrigers.Rows.Count; trg++)
                    {
                        treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[0].Nodes[j].Nodes[2].Nodes.Add(dataTrigers.Rows[trg][0].ToString(), dataTrigers.Rows[trg][0].ToString(), "Trigger", "Trigger");
                    }

                }
                //load Views under database
                treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes.Add("Views", "Views", "Folder", "Folder");
                var dataViews = Usermanager.GetView(Usermanager.Connection.CurrentUser.Database);
                for (int v = 0; v < dataViews.Rows.Count; v++)
                {
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[1].Nodes.Add(dataViews.Rows[v][0].ToString(), dataViews.Rows[v][0].ToString(), "View", "View");
                    var dataColumnsv = Usermanager.GetColumnOfTable(dataViews.Rows[v][0].ToString());
                    for (int vs = 0; vs < dataColumnsv.Rows.Count; vs++)
                    {
                        treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[1].Nodes[v].Nodes.Add(dataColumnsv.Rows[vs][0].ToString(), dataColumnsv.Rows[vs][0].ToString(), "Column", "Column");
                    }
                }
                //load Proccedures under database
                treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes.Add("Procedures", "Procedures", "Folder", "Folder");
                var dataProcedure = Usermanager.GetProcedure(Usermanager.Connection.CurrentUser.Database);
                for (int p = 0; p < dataProcedure.Rows.Count; p++)
                {
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[2].Nodes.Add(dataProcedure.Rows[p][0].ToString(), dataProcedure.Rows[p][0].ToString(), "Procedure", "Procedure");
                }
                //load functions under database
                treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes.Add("Functions", "Functions", "Folder", "Folder");
                var dataFunction = Usermanager.GetFunctions(Usermanager.Connection.CurrentUser.Database);
                for (int p = 0; p < dataFunction.Rows.Count; p++)
                {
                    treeView1.Nodes[0].Nodes[Usermanager.Connection.CurrentUser.Database].Nodes[3].Nodes.Add(dataFunction.Rows[p][0].ToString(), dataFunction.Rows[p][0].ToString(), "Function", "Function");
                }

            //}

            //load users from databases
            for (int i = 0; i < dataUsers.Rows.Count; i++)
            {
                treeView1.Nodes[1].Nodes.Add(dataUsers.Rows[i][0].ToString(), dataUsers.Rows[i][0].ToString(), "User", "User");
            }
            
        }
        private void LoadImgtree()
        {
            treeView1.ImageList = new ImageList();
            treeView1.ImageList.Images.Add("Folder", TB2.Properties.Resources.folder);
            treeView1.ImageList.Images.Add("Table", TB2.Properties.Resources.table);
            treeView1.ImageList.Images.Add("DB", TB2.Properties.Resources.db);
            treeView1.ImageList.Images.Add("User",TB2.Properties.Resources.user);
            treeView1.ImageList.Images.Add("Column", TB2.Properties.Resources.column);
            treeView1.ImageList.Images.Add("View", TB2.Properties.Resources.view);
            treeView1.ImageList.Images.Add("Procedure", TB2.Properties.Resources.procedure);
            treeView1.ImageList.Images.Add("Function", TB2.Properties.Resources.function);
            treeView1.ImageList.Images.Add("Index", TB2.Properties.Resources.index);
            treeView1.ImageList.Images.Add("Trigger", TB2.Properties.Resources.trigger);
            treeView1.ImageList.Images.Add("Tablespace", TB2.Properties.Resources.tablespace);


        }
        private void BTRefresh_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
                 LoadtreeDB();
                 treeView1.ExpandAll();
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                LoadTree();
            }
        }

        private void procedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewProcedure(tool, Usermanager);
                form.Show();
            }
            else
                 MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null && Usermanager.Connection.CurrentUser.Database!=null)
            {
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent.Text.Equals("Procedures"))
                {
                    Usermanager.ShowProccedureDDL(treeView1);
                    treeView1.SelectedNode = null;
                }
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent.Text.Equals("Functions"))
                {
                    Usermanager.ShowFunctionDDL(treeView1);
                    treeView1.SelectedNode = null;
                }

                if (treeView1.SelectedNode != null &&  treeView1.SelectedNode.Parent.Text.Equals("Views"))
                {
                    Usermanager.ShowViewDDL(treeView1);
                    treeView1.SelectedNode = null;
                }
                if (treeView1.SelectedNode != null &&  treeView1.SelectedNode.Parent.Text.Equals("Triggers"))
                {
                    Usermanager.ShowTriggerDDL(treeView1);
                    treeView1.SelectedNode = null;
                }
                if ( treeView1.SelectedNode!=null && treeView1.SelectedNode.Parent.Text.Equals("Tables"))
                {
                    Usermanager.ShowTable_ColumnDDL(treeView1);

                    treeView1.SelectedNode = null;
                }
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent.Text.Equals("Indexes"))
                {
                    Usermanager.ShowIndexDDL(treeView1);
                    treeView1.SelectedNode = null;
                }
            }
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewFunction(tool, Usermanager);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void schemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewDatabase(tool, Usermanager);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewIndex(tool, Usermanager);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void vIewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewView(tool, Usermanager);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new CreateUser(Usermanager,tool);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void triggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewTrigger(tool,Usermanager);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usermanager.Connection.CurrentUser.Database != null)
            {
                var form = new NewTable(tool, Usermanager);
                form.Show();
            }
            else
                MessageBox.Show("You must Login to a Database", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

    }

}

