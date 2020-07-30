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
            // L84 use start method to start timer which is a tic event
            //Attribute the end of a second, not the beginning of the first (0)second
            timer1.Start();

            // button1 will stop timer2 
            timer2.Stop();

            // Not in lesson
            timer3.Stop();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Attribute the end of a second, not the beginning of the first (0)second
            timer2.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // NOT in lesson
        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // L84 stop the timer1, before message, or it will continue looping
            timer1.Stop();

            // L84 show the message after timer stops at 1 second time lapse from the starting point
            MessageBox.Show("1 second has elapsed", timer1.Interval.ToString() + " millaseconds");
        }

        // L84 global variable counter
        int iCount = -1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            // L84 increment count 1 every tick event
            iCount++;

            // L84 show all the numbers, as count is incremented '+='
            // show only the number, that the count is currently on '='
            textBox1.Text = iCount.ToString() + " ";
        }
        // Not in lesson assign int value to another int
        public class A
        {      
            public static int iCount;
            int i = iCount;
        }
        int iCount2 = A.iCount;

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                iCount2 = Convert.ToInt32(textBox2.Text);
                textBox2.Text = "";
            }

            else
            {
                
                timer3.Stop();
                iCount2 = 1;
            } 
            iCount2 --;
            textBox2.Text = iCount2.ToString() + " ";
            textBox1.Text = iCount2.ToString() + " ";
            

            if (iCount2 == 0)
            {
                timer3.Stop();
                MessageBox.Show("spam deployed");
            }
        }
    }
}
