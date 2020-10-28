﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// L167 contains the EInumerable interface in it
using System.Collections;

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
            // L167 call our GetNumbers method, add values for the min and max int vars.
            // as it is here the program will stop and do nothing, when button1 pressed
            GetNumbers(0, 10);
            // L167 with a foreach statement it will iterate to the max and show a messagebox for each
            foreach (int i in GetNumbers(0, 10))
            {
                // L167 break out of the foreach statement when value equals 3
                if (i == 5) break;
                MessageBox.Show(i.ToString());
            }
        }

        // L167 IEnumerable method that yield returns a minimum number as needed
        IEnumerable GetNumbers(int min, int max)
        {
            // L167 iterate when a min is needed until reaching the max number
            for(; min <+ max; min++)
            {
                // L167 yields a return only when needed, not all at once
                yield return min;
            }
        }
    }
}
