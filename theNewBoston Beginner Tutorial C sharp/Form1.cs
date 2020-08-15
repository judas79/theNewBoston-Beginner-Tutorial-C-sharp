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
           // call our function to dissable all controls, pass in this.Control
           accessAll(this.Controls);
        }

        // L103 recusive method to access controls in containers
        void accessAll(Control.ControlCollection ccc)
        {
            // L104 iterate thru each of the form1 Controls
            foreach (Control c in ccc)
            {
                // L104 change each top level controls' to disabled,
                //c.Enabled = false;

                // L104 change only the buttons to be disabled
                //if (c is Button) c.Enabled = false;
                
                // L104 check all the checkBox boxes
                // chectk to see if it is a checkbox
                if (c is CheckBox)
                {
                    // if its a checkbox create a checkBox
                    CheckBox ch = c as CheckBox;
                    // put a check in the checkbox
                    ch.Checked = true;
                }
                
                // L104 if any button pressed, diplay messageBox
                if(c is Button)
                {
                    // L104 make b a control 'c' button object
                    Button b = c as Button;
                    // L104 create a new click event handler use tab 2x to generate
                    b.Click += new EventHandler(B_Click1);
                    
                }
                
                // L104 to see if thier are controls in containers, a bool is returned
                // if true, pass all c contols through accessAll to change child control text
                if (c.HasChildren) accessAll(c.Controls);
            }
        }

        // L104 generated event handler for button
        private void B_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("a button has been pressed");
        }
    }
}
