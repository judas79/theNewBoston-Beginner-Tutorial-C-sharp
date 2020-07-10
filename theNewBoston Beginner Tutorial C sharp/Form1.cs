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
// added L63
using System.Diagnostics;
// added L69
using System.Threading;



namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // L69 set up Thread variable global
        Thread tFreeze;

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                // call Freeze function
                //Freeze(); 

                // L69 create a thread for Freeze
                //Thread tFreeze = new Thread(Freeze);

                // L68 using global Thread
                tFreeze = new Thread(Freeze);

                // L69 invoke (start) Freeze method
                tFreeze.Start();
            }

            // L69 freeze function that loops
            void Freeze()
            {
                // endless loop method to freeze program
                for (; ; );
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
            button1.Enabled=true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tFreeze.Abort();
        }
    }
}
