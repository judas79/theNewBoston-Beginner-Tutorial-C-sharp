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

        // L83 FontDialog is global name
        FontDialog IFD;
        private void button1_Click(object sender, EventArgs e)
        {
            // L83 create instance of FontDialog
            IFD = new FontDialog();

            // L83 set max and min size using properties, for size
            IFD.MinSize = 10;
            IFD.MaxSize = 18;

            // L83 enable the user to choose the font color from fontdialog by showing the color picker
            IFD.ShowColor = true;

            // L83 show the help button, in FontDialog window.
            IFD.ShowHelp = true;

            // L83 enable the help button to do something when help is clicked (event)
            IFD.HelpRequest += IFD_HelpRequest;

            // L83 verify user has selected somehting
            if (IFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // L83 set font in textBox1 to fontdialog selected
                textBox1.Font = IFD.Font;

                // L83 set textBox1 to show font (foreground) colors selected from colordialog
                textBox1.ForeColor = IFD.Color;
            }

           
        }

        // L83 handles help button event request (help button clicked)
        private void IFD_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose font type and size by clicking on them, and choose font color, from dropdown, click ok");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
   
        }


        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
          
        }
    }
}
