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

            // L127 instance of graphics to use for all brushes, pens and gradient brushes
            // created in our form1 constructor for panel1
            Ig = panel1.CreateGraphics();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        // L127 variable to paint, or not to, set to not paint
        bool canPaint = false;

        // L127 instance of graphic to use for all brushes, pens and gradient brushes
        // created in our form1 constructor for panel1, it can't be created here
        Graphics Ig;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // L127 can paint, mouse is in the held down position
            canPaint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // L127 can't paint, mouse is in upward position
            canPaint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // L127 mouse is moving and canPaint true(mouse is being pressed), paint something
            if (canPaint)
            {
                // L127 instance for solidbrush to paint with, black line
                SolidBrush Isb = new SolidBrush(Color.Black);

                // 127 small fillElispe cricles to make a line, from graphics
                // arguements are: SolidBrush instance, get mouses (x,y) cursor positions
                // pass in 'e' (events) for x and y from MouseEventsArgs, get width/heigth
                // from our toolStrip textBox Text, convert string entered into an int
                Ig.FillEllipse(Isb, e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
