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
            /*
            // L52 string names, semicolon between them
            string sSemiColonFNames = "John;Adam;Spock;Mike;Kirk;Spaz";
            string sSemiColonFNames2 = "John Adam Spock Mikem Kirk Spaz";

            // L52 string array, sSemiColonFNames into separate items in array
            // the splits occur in order using the (';') whatever char, you choose 
            string[] saSeparatedFNames = sSemiColonFNames.Split(';');
            string[] saSeparatedFNames2 = sSemiColonFNames2.Split(' ');

            // L52 display saSeparatedFNames array names in message box using foreach
            foreach (string sFName in saSeparatedFNames)
                MessageBox.Show(sFName + "\n");

            // NOT IN LESSON
            for (int i = 0; i < saSeparatedFNames2.Length; i++)
            {
                string s = saSeparatedFNames2[i];
                MessageBox.Show(s + "\n");
                textBox1.Text += s+ " ";
            }
            */                              // GO TO NEXT EXAMPLE

            // L52 string partial alphabet
            string _sLetters = "abcdefghijkl";

            // split string in individual char items
            char[] caLetter = _sLetters.ToCharArray();
           
            
            for (int i = 0; i < caLetter.Length; i++)
            {
                char s = caLetter[i];
                MessageBox.Show(s.ToString() + "\n");
                textBox1.Text += s.ToString() + " ";
            }

            textBox1.Clear();

            // display using textBox1 and for each
            foreach (char c in caLetter)
            {
                textBox1.Text += c + " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
