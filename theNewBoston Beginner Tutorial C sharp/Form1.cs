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
            /*
            // L103 iterate thru each of the form1 Controls
            foreach(Control c in this.Controls)
            {
                // change each top level controls' name to adam,
                c.Text = "adam";
            }
            */
            // L103 call our accessAll in our method in form1
            accessAll(this.Controls);
        }

        // L103 recusive method to access controls in containers
        void accessAll(Control.ControlCollection ccc)
        {
            // L103 iterate thru each of the form1 Controls
            foreach (Control c in ccc)
            {
                // change each top level controls' name to adam,
                c.Text = "adam";
                // L103 to see if thier are controls in containers, a bool is returned
                // if true, pass all c contols through accessAll to change child control text
                if (c.HasChildren) accessAll(c.Controls);
            }
        }
    }
}
