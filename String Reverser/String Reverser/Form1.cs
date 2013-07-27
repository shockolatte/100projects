using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userText = textBox1.Text; //Accepts user input.
            string finalText = ""; //Creates the final string, which will be displayed.
            int len = userText.Length - 1; //Figures out how long the user's string is, and subtracts 1 from it, to make up for Array numbering.
            while (len >= 0) //While the length is grater than 0, it will preform the rest of the code.
            {
                finalText += userText[len]; //Adds the letter at the (len) position to the final text.
                len--; //Subtracts 1 from length to allow the program to move on to the next letter.
            }
            MessageBox.Show(finalText.ToString()); //Shows the final text.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
