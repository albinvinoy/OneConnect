using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OneConnect
{
    public partial class Form1 : Form
    {
        private enum DatabaseType {Sqlite, SQL };
        private DatabaseType currentDatabaseType;
        private string _filepath = "";
        private static SqlKeyWords words = new SqlKeyWords();
        private List<string> keywords = Words.reservedWords;

        private DatabaseType CurrentDatabaseType { get => currentDatabaseType; set => currentDatabaseType = value; }
        public string Filepath { get => _filepath; set => _filepath = value; }
        internal static SqlKeyWords Words { get => words; set => words = value; }
        public List<string> Keywords { get => keywords; set => keywords = value; }

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            string dbCommand = txt_schema.Text;
            if(CurrentDatabaseType == DatabaseType.Sqlite)
            {
                if (Filepath == string.Empty)
                {
                    Filepath = chooseFile();
                }

                SqLiteDb sqLiteDbConn = new SqLiteDb(Filepath);
                sqLiteDbConn.openDb();
                var reader = sqLiteDbConn.executeCommand(dbCommand);
                fillGridView(reader);
                sqLiteDbConn.closeDB();
            }

            
        }

        private void fillGridView(IDataReader reader)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = reader;

            dataGridView1.DataSource = bs;            
        }

        private void txt_schema_KeyUp(object sender, KeyEventArgs e)
        {
            // check for key up and hilight the text
            // Console.WriteLine(keywords);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sqlLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //on load for selecting sqlite
            CurrentDatabaseType = DatabaseType.Sqlite;
            //if (_filepath == string.Empty)
            //{
            Filepath = chooseFile();
            //}
            SqLiteDb sqLiteDbConn = new SqLiteDb(Filepath);
            try
            {
                //sqLiteDbConn.connectionString = filepath;
                bool pass = sqLiteDbConn.openDb();
                //lbl_Error.Text = string.Format("*** Connection *** {0}", pass);
                lbl_databaseName.Text = string.Format("Connected to {0} - {1}", sqLiteDbConn.dbName, "SQLite Database");

                List<string> tableData = sqLiteDbConn.getTableNames();
                cmb_tableName.DataSource = tableData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            sqLiteDbConn.closeDB();
        }

        private void txt_schema_TextChanged(object sender, EventArgs e)
        {
            
        }

        private string chooseFile()
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Filepath = folderBrowserDialog.FileName;
            }
            return Filepath;
        }

        private void CreateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentDatabaseType = DatabaseType.SQL;
            Sql sqlDbConn = new Sql(@"DESKTOP-2QVKASI\SQL2012", "AdventureWorksDW2012EE", "sa", "123");
            try
            {
                //sqLiteDbConn.connectionString = filepath;
                bool pass = sqlDbConn.openDb();
                //lbl_Error.Text = string.Format("*** Connection *** {0}", pass);
                lbl_databaseName.Text = string.Format("Connected to {0} - {1}", sqlDbConn.dbName, "SQL Database");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            sqlDbConn.closeDB();
        }

        private void btn_getSchema_Click(object sender, EventArgs e)
        {
            if (DatabaseType.Sqlite == CurrentDatabaseType)
            {
                if (Filepath == string.Empty)
                {
                    Filepath = chooseFile();
                }
                SqLiteDb sqLiteDbConn = new SqLiteDb(Filepath);
                sqLiteDbConn.openDb();
                var tableData = sqLiteDbConn.getTableData();
                sqLiteDbConn.closeDB();
            }
            else if(DatabaseType.SQL == CurrentDatabaseType)
            {
                Sql sqlDbConn = new Sql(@"DESKTOP-2QVKASI\SQL2012", "AdventureWorksDW2012EE", "sa", "123");
                sqlDbConn.openDb();
                var tableData = sqlDbConn.getTableData();
                sqlDbConn.closeDB();

            }
        }
        private void sqliteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentDatabaseType = DatabaseType.Sqlite;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Filepath = folderBrowserDialog.SelectedPath + "\\test.db";
            }
            
            SqLiteDb sq = new SqLiteDb(Filepath);
            sq.createDb(Filepath + "\\test.db");
            sq.openDb();
            
            Console.WriteLine(sq.connectionString);
            Console.WriteLine(sq.isConnectionOpen);
            sq.closeDB();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // https://support.microsoft.com/en-us/help/307283/how-to-create-a-sql-server-database-programmatically-by-using-ado-net
        }

        private void fillSchema(string tableName)
        {
            string selectProcedure = string.Format("select * from {0};", tableName);
            if (Filepath == string.Empty)
            {
                Filepath = chooseFile();
            }

            SqLiteDb sqLiteDbConn = new SqLiteDb(Filepath);
            sqLiteDbConn.openDb();
            var reader = sqLiteDbConn.executeCommand(selectProcedure);
            fillGridView(reader);
            sqLiteDbConn.closeDB();
        }

        private void cmb_tableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = (string)cmb_tableName.SelectedValue;
            fillSchema(tableName);
        }

    }
}
