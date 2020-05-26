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
            string[] myArray = {"zero", "one", "two"};

            MessageBox.Show(myArray[2], myArray[1] + " " + myArray[0]);
            MessageBox.Show(myArray[0] + " " + myArray[1], myArray[1] + " " + myArray[2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] emptyArrayName = new string[10];

            emptyArrayName[0] = "first item";
            emptyArrayName[2] = "third item";
            emptyArrayName[4] = "fith item";
            MessageBox.Show(emptyArrayName[0] + emptyArrayName[1] + ", emptyArrayName[1] has no items, " + emptyArrayName[2], emptyArrayName[4]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = "could not use an array item as a title, but a string var is ok";
            int[] integerName = { 0, 11, 12, 3 };
            bool[] booleanName = { true, false, true, false };

            MessageBox.Show((integerName[2] + integerName[1]) + " - notice integerName[2] and integerName[1] where added together, integerName[0] = "
                + integerName[0], name);
            MessageBox.Show(booleanName[0] + " " + booleanName[1], "two arrays work as titles here, WTF? " + booleanName[1] + " " + booleanName[2]);
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
