using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void guessBox_Click(object sender, EventArgs e)
        {
            StringBuilder wordGss = new StringBuilder(secretWord.Text);
            StringBuilder guessWrd = new StringBuilder(textBox1.Text);

            if(guessWrd.ToString().Equals("computer"))
            {
                wordGss.Clear();
                wordGss.Append(guessWrd.ToString());
                secretWord.Text = guessWrd.ToString();
                MessageBox.Show("Correct Guess !");
            }
            else
            {
                wrongAnswer.Items.Add(textBox1.Text);
                guessWrd.Clear();
                MessageBox.Show("Wrong guess! Try again.");
            }
        }
    }
}
