﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for drawing gradients
using System.Drawing.Drawing2D;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // L124 create instance of with arguements: starting point x/y, end point x/y, starting color, ending color
            LinearGradientBrush Ilgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Red, Color.Yellow);

            // L124 create graphics on panel1
            Graphics Ig = panel1.CreateGraphics();

            // L124 render graphic of the gradiant within a fill rectangle arguments: 
            // instance ofLinearGradientBrush, starting point of rectangle, ending point of the rectangle
            Ig.FillRectangle(Ilgb, 20, 20, 50, 50);
            Ig.FillRectangle(Ilgb, 20, 70, 100, 50);
            Ig.FillRectangle(Ilgb, 120, 20, 160, 40);

            // L124 make a circle using FillSphere arguements:
            // instance ofLinearGradientBrush, starting point of fill elipse, ending point of the Elipse
            Ig.FillEllipse(Ilgb, 170, 60, 170, 60);
        }
    }
}
