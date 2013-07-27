using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result = openFileDialog1.ShowDialog();//Allows user to browse for a file.
            if (result == DialogResult.OK) // Test result.
	        {
                string file = openFileDialog1.FileName;//Opens the file.
		        string text = System.IO.File.ReadAllText(file);//Reads the File.
                richTextBox1.Text = text;//Displays the file in the textbox.
             }
		        
		}   
	       
        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {


            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
