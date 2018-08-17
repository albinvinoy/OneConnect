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
            string getSchemaText = txt_schema.Text;
            Console.WriteLine(getSchemaText);
        }

        private void txt_schema_KeyUp(object sender, KeyEventArgs e)
        {
            // check for key up and hilight the text
            
            Console.WriteLine(keywords);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sqlLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "";

            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = folderBrowserDialog.FileName;
            }

            SqLiteDb sqLiteDbConn = new SqLiteDb(filepath);
            //sqLiteDbConn.connectionString = filepath;
            bool pass = sqLiteDbConn.openDb();
            txt_schema.Text = string.Format("*** Connection *** {0}", pass);
            DataTable sqliteTable = sqLiteDbConn.getTableData();

            // Returns all column names of the table
            foreach (DataRow row in sqliteTable.Rows)
            {
                Console.WriteLine((string)row[2]);
            }
        }
    }
}
