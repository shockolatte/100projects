using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Count_the_Vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string users_text = textBox1.Text; //Accepts the user's text.
            int int_a = 0;//Keeps track of the number of "A"s.
            int int_e = 0;//Keeps track of the number of "E"s.
            int int_i = 0;//Keeps track of the number of "I"s.
            int int_o = 0;//Keeps track of the number of "O"s.
            int int_u = 0;//Keeps track of the number of "U"s.
            int vowels = 0;//Keeps track of the number of vowels.

            foreach (char letter_char in users_text)//Checks each letter in the word.
            {
                
                string letter_str = letter_char.ToString();//converts the letter to a string to make comparing easier.
                if (letter_str == "a" || letter_str == "A")//compares the letter to an "A"
                {
                    int_a++;//adds 1 to the "A" count
                    vowels++;//adds to the number of vowels.
                }
                else if (letter_str == "e" || letter_str == "E")//compares the letter to an "E"
                {
                    int_e++;//adds 1 to the "E" count
                    vowels++;//adds to the number of vowels.
                }
                else if (letter_str == "i" || letter_str == "I")//compares the letter to an "I"
                {
                    int_i++;//adds 1 to the "I" count
                    vowels++;//adds to the number of vowels.
                }
                else if (letter_str == "o" || letter_str == "O")//compares the letter to an "O"
                {
                    int_o++;//adds 1 to the "O" count
                    vowels++;//adds to the number of vowels.
                }
                else if (letter_str == "u" || letter_str == "U")//compares the letter to an "U"
                {
                    int_u++;//adds 1 to the "U" count
                    vowels++;//adds to the number of vowels.
                }
                
            }

            MessageBox.Show("The word " + users_text + " has " + vowels.ToString() +" vowels. There are " + int_a + " a's, " + int_e + " e's, " + int_i + " i's, " + int_o + " o's, " + int_u + " u's.");//Displays the final message. 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
