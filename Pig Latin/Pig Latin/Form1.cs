using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pig_Latin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string users_text = textBox1.Text; //Accepts users input through Textbox1.
            char first_letter_char = users_text[0]; //Finds the first letter of the user's text.
            string first_letter = first_letter_char.ToString();
            int text_length = users_text.Length; //Finds the length of the user's text.
            string text_without_first_letter = users_text.Substring(1, text_length - 1); //Creates a string out of the User's text without the first letter.
            if (first_letter == "a" || first_letter == "e" || first_letter == "i" || first_letter == "o" || first_letter == "u" || first_letter == "y" || first_letter == "A" || first_letter == "E" || first_letter == "I" || first_letter == "O" || first_letter == "U" || first_letter == "Y")
            {
                MessageBox.Show(users_text + "way");
            }
            else
            {
                MessageBox.Show(text_without_first_letter + first_letter + "ay");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
