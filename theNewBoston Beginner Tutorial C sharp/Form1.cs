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
            if (textBox1.Text == "adam")
            {
                MessageBox.Show("adam matches");
            }
            else if (textBox1.Text == "bob")
            {
                MessageBox.Show("bob matches");
            }
            else
            {
                MessageBox.Show("No matches");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "adam")
            {
                MessageBox.Show("names don't match");
            }
        }
    }
}
