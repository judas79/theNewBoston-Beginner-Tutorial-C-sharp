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
            /* L45
            try
            {
                // L45 convert string to integer, using 
                int iConverted = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(iConverted.ToString());
                textBox1.Clear();
            }
            catch (Exception)
            {
                // message box tells user the error and to clear (the text entered in button1)
                MessageBox.Show("whole integers only!  \nClear " + textBox1.ToString());                             
            }
            */                                                  // GO TO NEXT EXAMPLE
            /*
            try
            {
                // L45 convert string to integer, using Convert.ToInt32 and adding 100
                int iConverted = Convert.ToInt32(textBox1.Text)+100;
                MessageBox.Show(iConverted.ToString());
                textBox1.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("whole integers only!  \nClear " + textBox1.ToString());
            }
            */                                                   // GO TO NEXT EXAMPLE
            /*
            try
            {
                // L45 convert string to char, using 
                char cConverted = Convert.ToChar(textBox1.Text);
                MessageBox.Show(cConverted.ToString());
                textBox1.Clear();
            }
            catch (Exception)
            {            
                MessageBox.Show("One char character only or nothing entered!  \nCLEAR " + textBox1.ToString()+"\n Then start again");
            }
            */                                                  // GO TO NEXT EXAMPLE
            /*
            try
            {
                // L45 convert string to char, using 
                bool bConverted = Convert.ToBoolean(textBox1.Text);
                MessageBox.Show(bConverted.ToString());
                textBox1.Clear();
            }
            catch (Exception)
            {            
                MessageBox.Show("True or False only!  \nCLEAR " + textBox1.ToString()+"\n Then start again");
            }
            */                                                   // GO TO NEXT EXAMPLE
            /*
            // NOT IN LESSON get ASCII in Hexadecimal
            try
            {
                
                // convert string to byte, using 
                byte[] bConverted = Encoding.Default.GetBytes(textBox1.Text);
                
                // get a string with dashes
                var sConverted = BitConverter.ToString(bConverted);
                
                // replace the dash with a space
                sConverted = sConverted.Replace("-", " ");

                MessageBox.Show((textBox1.Text) + "\nconverted to ASCII Hexadecimal\n" + sConverted.ToString());
                textBox1.Clear();
            }
            catch (Exception)
            {            
                MessageBox.Show("what did you enter?!  \nCLEAR " + textBox1.ToString()+"\n Then start again");
            }
            */
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
