﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // L126 instance of graphicPath
            GraphicsPath Igp = new GraphicsPath();

            // L126 add a circular path for graphicpath to follow
            Igp.AddEllipse(20, 20, 50, 50);

            // L126 instance of pathGradientBrush
            PathGradientBrush Ipgb = new PathGradientBrush(Igp);

            // L126 create center color for our PathGradientBrush instance arguement, center color
            Ipgb.CenterColor = Color.Blue;

            // L126 use array to define the surrounding colors
            Ipgb.SurroundColors = new Color[] { Color.Yellow };

            // L126 creategraphics form panel1 to write, draw or paint on
            Graphics Ig = panel1.CreateGraphics();

            // L126 draw the circle, arguements: brush type, starting x/y coordinates, and ending quardinates
            Ig.FillEllipse(Ipgb, 20, 20, 50, 50);

            GraphicsPath Igp2 = new GraphicsPath();
            Igp2.AddEllipse(100, 20, 50, 50);
            PathGradientBrush Ipgb2 = new PathGradientBrush(Igp2);
            Ipgb2.CenterColor = Color.White;
            Ipgb2.SurroundColors = new Color[] { Color.Black };
            Ig.FillEllipse(Ipgb2, 100, 20, 50, 50);

            // L127 new grapicspath for this lesson
            GraphicsPath Igp3 = new GraphicsPath();

            // L127 create a triangle and its arguemts x/y starting, width/heigth
            Rectangle Ir = new Rectangle(20, 120, 50, 50);

            // L127 add rectangle and then pass in the rectangle above
            Igp3.AddRectangle(Ir);

            // L126 All explained in tutorial 126
            PathGradientBrush Ipgb3 = new PathGradientBrush(Igp3);
            Ipgb3.CenterColor = Color.Green;
            Ipgb3.SurroundColors = new Color[] { Color.Blue };

            // L127 use our graphics to Fill our rectangle
            Ig.FillRectangle(Ipgb3, 20, 120, 50, 50);

            // **************** polygon ****************

            // L127 new grapicspath for this lesson
            GraphicsPath Igp4 = new GraphicsPath();

            // L127 create polygon point array triangle
            Point[] points = { new Point(100, 120), new Point(120, 170), new Point(150, 170) };

            // L127 add the polygon to our graphic path
            Igp4.AddPolygon(points);

            // L126 All explained in tutorial 126
            PathGradientBrush Ipgb4 = new PathGradientBrush(Igp4);
            Ipgb4.CenterColor = Color.Purple;
            Ipgb4.SurroundColors = new Color[] { Color.Red };

            // L127 use our graphics to Fill our rectangle
            Ig.FillPolygon(Ipgb4, points);

            // *********** polygon 4 points *************

            // L127 new grapicspath for this lesson
            GraphicsPath Igp5 = new GraphicsPath();

            // L127 create polygon point array triangle
            Point[] points2 = { new Point (170, 120), new Point(200, 190), new Point(220, 160), new Point(270, 170) };

            // L127 add the polygon to our graphic path
            Igp5.AddPolygon(points2);

            PathGradientBrush Ipgb5 = new PathGradientBrush(Igp5);
            Ipgb5.CenterColor = Color.Orange;
            Ipgb5.SurroundColors = new Color[] { Color.Yellow };

            // L127 use our graphics to Fill our rectangle
            Ig.FillPolygon(Ipgb5, points2);
        }
    }
}
