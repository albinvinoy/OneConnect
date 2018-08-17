using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private static SqlKeyWords words = new SqlKeyWords();
        private List<string> keywords = words.reservedWords;

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

        private void btn_openDb_Click(object sender, EventArgs e)
        {

        }
    }
}
