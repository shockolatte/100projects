using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Count_Strings_in_txt_Document
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string doc_location = textBox1.Text;//Allows the user to input the document's location.
                string input = System.IO.File.ReadAllText(@doc_location);//Read's the document.
                int count = 0;//Keeps track of the number of space in the document.
                foreach (char character in input)//Will check each character in the document for a space. Since words tend to be sperated by spaces.
                {
                    if (character.ToString() == " ")//If the letter is a space it will add 1 to our count.
                    {
                        count++;
                    }
                }
                MessageBox.Show("The document has " + (count + 1) + " strings in it");//Displays a message showing the number of strings. Usually there are spaces at the end of every string, except for the last one, so we add 1 to the count.
            }
            catch
            {
                MessageBox.Show("File not found.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
