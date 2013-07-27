using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Check_if_Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string users_text = textBox1.Text;//Accepts the user's text.
            int text_length = users_text.Length;//Tells how long the text is.
            int text_countdown = text_length-1;//Creates an int that will allow a later foreach statement to countdown.
            int counter = 0;
                foreach (char letter in users_text)//will check each letter in user's text.
                {
                    if (letter == users_text[text_countdown])//Checks if the letter is equal to the one on the opposing spot)
                    {
                        text_countdown--;
                        counter++;
                    }
                }
                if (counter == text_length)//Checks if the counter has checked every letter succesfully. 
                {
                    MessageBox.Show("That word IS a palindrome!");
                }
                else
                {
                    MessageBox.Show("That word is NOT a palindrome.");
                }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
