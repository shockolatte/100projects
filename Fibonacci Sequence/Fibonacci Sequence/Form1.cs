using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonacci_Sequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0; //The first number in the equation.
            int n2 = 1; //The Second number in the equation.
            String sequence = "0,1,"; //Will be used to keep track of the sequence.
            int n3 = 0; //Will be used to hold the next number, and will be switched to n2 to continue the sequence.
            int sequence_point = 0; //Will be used to keep track of how far along we are in the sequence for the while.
            int sequence_number = System.Convert.ToInt32(textBox1.Text); //Accpets the user's number.
            while (sequence_point <= (sequence_number-3))//Calculates what point we are in the sequence.
            {
                sequence += (n1+n2).ToString() + ",";//adds the next number to the final sequence to be shown back to the user.
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                
                sequence_point++;
            }
            MessageBox.Show(sequence);

        }
    }
}
