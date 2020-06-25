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

        // L39 string 
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            // L36 instance of openfildialog
            OpenFileDialog ofd = new OpenFileDialog();

            // L37 see if file opened ok
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // button2 set to True (active) when page is confirmed to be opened
                button2.Enabled = true;
                path = ofd.FileName;

                // Not in lesson
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L43 instance of BinaryWriter, open path to stream and write to.
            BinaryWriter iBW = new BinaryWriter(File.OpenWrite(path));

            // L43 write character C to the file
            //iBW.Write("C");                                       // Next example

            // L43 two bytes or Int16, d9999
            //short myShort = 9999;                                 // Next example

            // L43 two bytes or Int16, hex 0x1234                   
            //short myShort = 0x1234;                               // Next example

            // L43 four bytes or Int32, hex 0x1234                   
            int myShort = 0x12345678;                               // Next example

            // L43 byte array to using BitConverter to convert bytes
            byte[] buffer = BitConverter.GetBytes(myShort);

            // flip little endian stored in buffer
            Array.Reverse(buffer);

            // L43 write var. buffer to the file
            iBW.Write(buffer);

            // close properly
            iBW.Dispose();

            // Not in lesson
            //textBox1.Clear();
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
