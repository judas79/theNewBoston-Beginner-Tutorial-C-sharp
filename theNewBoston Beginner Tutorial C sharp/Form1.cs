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

        // L70 set up Thread variable global
        Thread tWrite;

        // L70 empty string to fix Thread debug error
        string sThreadFix = "";

        private void button1_Click(object sender, EventArgs e)
        {
            /* L71 pass in one parameter to thread
            {
             
                // L70 using global Thread
                tWrite = new Thread(Write);

                // L71 invoke (start) pass in object 'name' value
                tWrite.Start("Roddy");

                // L71 while, to wait for the for statement thread is complete before displaying output in textBox1
                while (tWrite.IsAlive) ;
                    textBox1.Text += sThreadFix;
            }

            // L70 function that loops 1000 times, using object 'name' parameter
            void Write(object name)
            {
                // L70 for loop method from 0 to 1000
                for (int i = 0; i < 1000; i++)

                    // L71 display text from object 'name' convert object name to sting 
                    // in textbox1 up to 1000 return and newline
                    sThreadFix += name.ToString() + ": " +  i.ToString() + "\r\n";
            }
            */   // end of pass in one parameter to thread

            // L71 pass in two parameters to thread
            {

                // L70 using global Thread
                tWrite = new Thread(Write);

                // L71 object array holds two paramteters elements
                object[] objA = { "Roddy", 1000 };

                // L71 invoke (start) pass through object 'oaNameI' value
                tWrite.Start(objA);

                // L71 while, to wait for the for statement thread is complete before displaying output in textBox1
                while (tWrite.IsAlive) ;
                textBox1.Text += sThreadFix;
            }

            // L70 function that loops 1000 times, using object 'name' parameter
            void Write(object oArray)
            {
                // L71 object array to hold two elements
                object[] o = oArray as object[];

                // L70 for loop method from 0 to 1000
                for (int i = 0; i < Convert.ToInt32(o[1]); i++)
                {
                    // L71 Thread sleeps every cycle for 10 milliseconds .010
                    Thread.Sleep(10);

                    // L71 display text from object 'name' convert object name to sting 
                    // in textbox1 up to 1000 return and newline
                    sThreadFix += o[0].ToString() + ": " + i.ToString() + "\r\n";
                }
                    
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
            tWrite.Abort();
        }
    }
}
