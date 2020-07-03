﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// added L20
using myNamespace;
// added L36 for StreamReader
using System.IO;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // L54 the Random class instance
            Random IRandom = new Random();

            // L55 char array, all letters of the alphabet (string), converted to char array
            char[] cLetters = "zxcvbnmasdfghjklqwertyuiop".ToCharArray();

            // generate one random index number to define the index for chars letter
            MessageBox.Show(cLetters[IRandom.Next(0, 25)].ToString());

            // generate more than one letter using a for statement
            string sRandom = "";
            for(int iCount=0; iCount<5; iCount++)
            {
                // add chars to string (+=)
                sRandom += cLetters[IRandom.Next(0, 25)].ToString();
            }
            MessageBox.Show(sRandom);


            // NOT IN TUTORIAL - Gibberish

            string sCapRandom = "";
            string sPuncRandom = "";
            string sSymRandom = "";
            string sTwoRandom = "";
            string sOneRandom = cLetters[IRandom.Next(0, 25)].ToString(); 

            char[] cCapLetters = "ZXCVBNMASDFGHJKLQWERTYUIOP".ToCharArray();
            char[] cSymbols = "!?.".ToCharArray();
            char[] cPunctuation = ",:;/".ToCharArray();
            char[] cTwo = ",:;/".ToCharArray();

            for (int iCount = 0; iCount < 1; iCount++)
            {
                sCapRandom += cCapLetters[IRandom.Next(0, 25)].ToString();
            }
            
            for (int iCount = 0; iCount < 1; iCount++)
            {
                sSymRandom += cSymbols[IRandom.Next(0, 2)].ToString();
            }
            
            for (int iCount = 0; iCount < 1; iCount++)
            {
                sPuncRandom += cPunctuation[IRandom.Next(0, 1)].ToString();
            }
            
            for (int iCount = 0; iCount < 2; iCount++)
            {
                sTwoRandom += cLetters[IRandom.Next(0, 1)].ToString();
            }

            MessageBox.Show(sCapRandom + sOneRandom + sTwoRandom + " " + sRandom + sPuncRandom + " " + sTwoRandom + sOneRandom + sSymRandom);

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
