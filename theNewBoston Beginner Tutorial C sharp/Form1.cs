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
        
        // L155 method to display hangman post in panel1
        void hangManPost()
        {
            //L155 instance of CreateGraphics in panel1
            Graphics gr = panel1.CreateGraphics();

            //L155 create pen draws 10 pixels and is brown
            Pen pn = new Pen(Color.Brown, 10f);

            // L155 draw starting points for line using graphics, pen and new Points
            // horizontal base
            gr.DrawLine(pn, new Point(157, 300), new Point(203, 300));
            // vertical line going up
            gr.DrawLine(pn, new Point (180, 300), new Point(180, 5));
            // horizontal line going left
            gr.DrawLine(pn, new Point(185, 5), new Point(60, 5));
            // vertical line going down
            gr.DrawLine(pn, new Point(65, 5), new Point(65, 50));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // L155 pass in hangManPost method to display in form1 using event Shown
            hangManPost();
        }
    }
}
