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
            // L144 set up switch example
            /// <summary>
            /// "aAdam is a name"
            /// </summary>
            string sAdam = "blah";
            switch (sAdam)
            {
                case "sAdam":
                    MessageBox.Show("Hello");
                    break;
                default:
                    MessageBox.Show("default");
                    // L144 instead of break, we use goto and jump label, to jump to case "sAdam":
                    //break;
                    goto case "sAdam";
            }
            // L144 jump to ourself label with goto
            goto MyCode;
        MyCode:
            {
                MessageBox.Show("what?");
            }

            // L144 goto statement in a for statement, jumps out of the for loop,
            // to 'MyCode2 below, so we only get 1 messagebox message.
            for( ; ; )
            {
                // NOT in lesson, we get infinite messageboxes, 1 at a time if we jump to 'MyCode', above.
                // We would also have to ommit
                //goto MyCode;
                goto MyCode2;
            }

        // L144 if the for statement jumps to MyCode2 it only prints out 1 time
        MyCode2:
            {
                MessageBox.Show("what?");
            }
        }

        // L144 create a #region named MyRegion, to hide my code, variables, the #endregion
        #region MyRegion
        int i = 0;
        string s = "";
        bool b = true;
        #endregion
    }
}
