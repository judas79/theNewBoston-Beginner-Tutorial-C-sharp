﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

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
            // L177 open file dialog instance
            OpenFileDialog OFD = new OpenFileDialog();

            // L177 folder browser dialog instance
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            // L177 if statement to check if file was opened
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // L177 create a zipFile instance, and a path to desktop file for it 
                ZipFile ZF = new ZipFile("C:\\Users\\judas\\Desktop\\MyZipFile.zip");

                // L177 add a directory name inside the zip file to put the open file dialog file in
                ZF.AddDirectoryByName("Data Logger");

                // L177 add the openFildDialog file, to the root area of our zip file
                //ZF.AddFile(OFD.FileName, "");
                // L177 put the directory within our zip file and put the open file dialog file in that directory
                ZF.AddFile(OFD.FileName, "Data Logger");

                // L177 create and save the zip file
                ZF.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L177 folder browser dialog instance
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            // L177 if statement to check if a directory was opened
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // L177 create a zipFile instance, and a path to desktop file for it 
                ZipFile ZF = new ZipFile("C:\\Users\\judas\\Desktop\\MyZipFile.zip");

                // L177 add a directory name inside the zip file to put the open file dialog file in
                // not being user in this example
                //ZF.AddDirectoryByName("Data Logger");

                // L177 put the contents of the directory, inside of our zip file 
                ZF.AddDirectory(FBD.SelectedPath, "");

                // L177 create and save the zip file
                ZF.Save();
            }
        }
    }
}
