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
            // L49 string
            string sFullName = "John Smith";

            // get substring of string 
            // (starting address of what you want to get, how many characters you wish to get
            string sLastName = sFullName.Substring(5, 5);
            string sFirstName = sFullName.Substring(0, 4);

            // get starting point through all the characters, to the end
            string sToEndName = sFullName.Substring(3);

            MessageBox.Show("last name: " + sLastName + ",\nfirst name: " + sFirstName + ",\npartial name: " + sToEndName);


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
