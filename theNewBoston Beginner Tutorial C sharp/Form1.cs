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
            // L47 set object to empty string
            object oMyString = "TRUE!";
            object oMyint = 12;
            
            // 47 use if and is to determine if var. is a string
            if(oMyString is string) MessageBox.Show("true, it a string", "Entered as Text: 'true, it a string'");
            else MessageBox.Show("False");

            // 47 use if and is to determine if var. is a string
            if (oMyString is string) MessageBox.Show(oMyString.ToString(), "string:  oMyString.ToString()");
            else MessageBox.Show("False");

            // 47 use if and is to determine if var. is an object string, if true convert to string
            if (oMyString is string) MessageBox.Show((string)oMyString, "Convert to string if, if statement is true: (string)oMyString");
            else MessageBox.Show("False");
           
            /* DID NOT WORK
            // 47 use if and is to determine if var. is a object int, if true convert to string
            if (oMyint is int)
                MessageBox.Show((string)oMyint, "Convert to string if, if statement is true: (string)oMyint");
            else MessageBox.Show("False");

              DID NOT WORK COULDN'T CONVERT OBJECT INT TO INT
            // 47 use if and is to determine if var. is a object int, if true convert to int
            if (oMyint is int) MessageBox.Show((int)oMyInt, "Convert to string if, if statement is true: (int)oMyint");
            else MessageBox.Show("False");
            */
            
            // L47 use if/ is to change control variable to cast as a Button
            Control cMyControl = button1;
            if(cMyControl is Button)
            {
                // notice parenthesis around cast (button)
                Button bMyButton = (Button)cMyControl;

                // notice .Text not .ToString()
                MessageBox.Show(bMyButton.Text);
            }

            // L47 use if/ is to change control variable to cast as a Button using 'as'
            Control cMyControl2 = button1;
            if(cMyControl2 is Button)
            {
                // notice 'as' after cMyControl2 then Button
                Button bMyButton = cMyControl2 as Button;

                // notice .Text not .ToString()
                MessageBox.Show(bMyButton.Text);
            }

            // 47 use as to convert string object to string
            object oMyString2 = "TRUE 2!";
            if(oMyString2 is string)
            {
                string sMyString2 = oMyString2 as string;
                MessageBox.Show(sMyString2);
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
