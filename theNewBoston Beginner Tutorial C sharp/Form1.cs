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

            // L56 check 'if' the instance makes the path
            if (IFBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("IFBD Functional");

                // L57 Directory class, get paths for individual files for string array
                string[] saFiles = Directory.GetFiles(IFBD.SelectedPath);

                // L57 display file paths in array sFiles using foreach statement
                foreach (string sEachFile in saFiles)
                {
                    MessageBox.Show(sEachFile, "File(s)");
                    label1.Text += "\nFile Path:  " + sEachFile;
                    textBox1.Clear();
                    textBox1.Text += "File Path:  :" + sEachFile + "  ";
                }

                // L57 Directory class, get paths for individual files for string array
                string[] saDirectoriess = Directory.GetDirectories(IFBD.SelectedPath);

                // L57 display file paths in array sFiles using foreach statement
                foreach (string sEachDirectory in saDirectoriess)
                {
                    MessageBox.Show(sEachDirectory, "Directorie(s)");
                    label1.Text += "\nDirectory Path:  " + sEachDirectory;
                    textBox1.Clear();
                    textBox1.Text += "Directory Path:  :" + sEachDirectory + "  ";
                    
                }

                string[] saLogicalDrives = Directory.GetLogicalDrives();
                foreach(string sDrive in saLogicalDrives)
                {
                    MessageBox.Show(sDrive, "Drive");
                    label1.Text += "\nDrive Path:  " + sDrive;
                    textBox1.Clear();
                    textBox1.Text += "Drive Path:  :" + sDrive + "  ";
                }
            }




            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
