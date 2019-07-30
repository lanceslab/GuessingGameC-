using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



void searchGuess() {
	int i, guessCount = 0, guess = 0, initialNumber = 1, maxNumber = 1000;
    bool isCorrect = false;
    int tNumber = Convert.ToInt32(textBox1.Text);    
    do
    {
        guess = getRandomInt(initialNumber, maxNumber);
        guessCount++;
        if(guess == tNumber) {
            isCorrect = true;
            listBox1.Items.Add("I guessed the correct number in " + guessCount + " tries!");
        }
        else if ( tNumber > guess ) {
            initialNumber = guess;
            guessCount++;
            //listBox1.Items.Add("I guessed HIGH.." + guess + " I'll try again ");
            listBox1.Items.Add("I guessed LOW.." + guess + " I'll try again ");
         }
        else if ( tNumber < guess ) {
            maxNumber = guess;
			guessCount++;
            //listBox1.Items.Add("I guessed LOW.." + guess + " I'll try again ");
            listBox1.Items.Add("I guessed HIGH.." + guess + " I'll try again ");
         }        
    } while (isCorrect == false);
}

        
int getRandomInt(int min, int max) {
    Random rnd = new Random();
    int month = rnd.Next(min, max);
    return month;// Math.floor(Math.random() * (max - min)) + min;
}








        //textBox1
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            searchGuess();
        }
    }
}
