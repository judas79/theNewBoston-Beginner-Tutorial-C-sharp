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
            int i = 0;
            if (textBox1.Text == "adam")
            {
                if (checkBox1.Checked)
                {
                    if (i == 0)
                    {
                        MessageBox.Show("adam entered, i equals 0, and check box checked");
                    }
                
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBox2.Text == "adam" && checkBox2.Checked && i ==0)
            {
                MessageBox.Show("textBox2 equals adam, checkBox2 is checked, and i equals 0");
            }
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked || textBox3.Text == "adam")
            {
                MessageBox.Show("checkBox3 Checked or the text entered is adam");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool myBool = false;

            if (!myBool)
            {
                MessageBox.Show("myBool is False");
            }
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
