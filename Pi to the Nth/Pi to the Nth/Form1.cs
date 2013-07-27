using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pi_to_the_Nth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pi = (Math.PI).ToString(); //Finds Pi
            int n = Convert.ToInt32(textBox1.Text); //Finds the user given number
            if (n == 1) //If the user's number is 1, we just show the 3.
            {
                MessageBox.Show("3");
            }
            else //If the user's number is more than 1, this will output pi to the "Nth" space. We add 1 to account for the decimal.
            {
                MessageBox.Show(pi.Substring(0, n + 1));
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
