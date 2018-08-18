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
        private string _filepath = "";
        private static SqlKeyWords words = new SqlKeyWords();
        private List<string> keywords = words.reservedWords;
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
            if (_filepath == string.Empty)
            {
                _filepath = chooseFile();
            }

            SqLiteDb sqLiteDbConn = new SqLiteDb(_filepath);
            sqLiteDbConn.openDb();
            sqLiteDbConn.executeCommand(dbCommand);

            sqLiteDbConn.closeDB();
        }

        private void txt_schema_KeyUp(object sender, KeyEventArgs e)
        {
            // check for key up and hilight the text
            
            //Console.WriteLine(keywords);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sqlLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_filepath == string.Empty)
            {
                _filepath = chooseFile();
            }
            SqLiteDb sqLiteDbConn = new SqLiteDb(_filepath);
            try
            {
                //sqLiteDbConn.connectionString = filepath;
                bool pass = sqLiteDbConn.openDb();
                //lbl_Error.Text = string.Format("*** Connection *** {0}", pass);
                lbl_databaseName.Text = string.Format("Connected to {0} - {1}", sqLiteDbConn.dbName, "SQLite Database");
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
                _filepath = folderBrowserDialog.FileName;
            }
            return _filepath;
        }
    }
}
