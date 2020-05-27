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
            // empty string array
            string[] myArray = { "zero", "one", "two" };

            // empty string list
            List<string> listName = new List<string>();

            // add a item to string list
            listName.Add("first item");

            // names are added to list sequntially, so its best to keep track, 
            // with comments at the lists definintion
            listName.Add("second item");

            // print to messageBox first item in list
            MessageBox.Show(listName[1], listName[0] + " - list items can be used in messagebox as a title");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] emptyArrayName = new string[10];

            // List integer (int) example
            List<int> listIntName = new List<int>(); // 00, 333, 555

            // add integers to int list
            listIntName.Add(00);
            listIntName.Add(333);
            listIntName.Add(555);
            MessageBox.Show(listIntName[2].ToString() + " - add .ToString() to " +
                "listIntName[2] to convert it from int to string, for printing to MessageBox"
                , listIntName[1].ToString() + " - listIntName[1].ToString() works to print to title field");
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
