﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            message();
        }

        void message()
        {
            MessageBox.Show("void Message");
            textBox1.Text += "void message ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            message();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            message2("button 3, using variable 'passIn' to pass this in", "Button 3 Title");
        }

        void message2(string passIn, string titleIn)
        {
            MessageBox.Show(passIn, titleIn);
            textBox3.Clear();
            textBox3.Text += passIn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            message2("button 4, using variable 'passIn' to pass this in", "Button 4 Title");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int c = 0;

            if (b>1)
            {
                MessageBox.Show("b is greater than a");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int c = 0;

            if (b != 4)
            {
                MessageBox.Show("b is not equal to 4");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int c = 0;

            if (5 >= c)
            {
                MessageBox.Show("5 is greater than or equal to " + c);
            }
        }
    }
}
