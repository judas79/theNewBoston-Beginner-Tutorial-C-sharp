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
            // L56 instance of FolderBrowserDialog
            FolderBrowserDialog IFBD = new FolderBrowserDialog();

            // L56 set description of the folder root your are opening
            IFBD.Description = "these sub-folders are your only choices";

            // L56 property to set a determined folder (root folder) for FolderBrowserDialog
            IFBD.RootFolder = Environment.SpecialFolder.UserProfile;

            // L56 check 'if' the instance makes the path
            if (IFBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("IFBD Functional");

                // Display the selected pat property
                MessageBox.Show(IFBD.SelectedPath);

                textBox1.Text = IFBD.SelectedPath;
                label1.Text = IFBD.SelectedPath;
            }


            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
