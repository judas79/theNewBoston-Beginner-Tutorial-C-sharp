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

        private void panel1_Click(object sender, EventArgs e)
        {
            // L119 create new solid brush, it paints is red
            SolidBrush SB = new SolidBrush(Color.Green);

            // 119 allow us create graphics on panel1
            Graphics G = panel1.CreateGraphics();

            //119 create the fill shape we will paint,
            // first parameters option is brushtype, where on x,y axis, then size x,y in pixels
            G.FillRectangle(SB, 35, 20, 150, 50);

            // 119 create fill shape elipse
            // first properties option is brushtype, where on x,y axis, then size x,y in pixels
            G.FillEllipse(SB, 75, 65, 50, 150);

            // 119 create fill shape elipse (circle)
            // first properties option is brushtype, where on x,y axis, then size x,y in pixels
            G.FillEllipse(SB, 75, 200, 50, 50);

            // 120 make a fill pie shape with a chunk missing, parameters:
            // solidBrush name, starting point x,y axis, x,y sizes,
            // start angle in degrees, sweep angle in degrees
            G.FillPie(SB, 200, 20, 50, 50, 0, 180);
            G.FillPie(SB, 250, 20, 50, 50, 90, 180);
            G.FillPie(SB, 200, 100, 50, 50, 180, 180);
            G.FillPie(SB, 250, 100, 50, 50, 270, 180);

            // L120 create point array for polygon, in x,y pairs,
            // staring x,y point, second x,y point, third x,y point
            Point[] PApoints = { new Point(350, 20), new Point(400, 20), new Point(375, 70)};

            // fill polygon parameters: brush type, then point array
            G.FillPolygon(SB, PApoints);

            Point[] PApoints2 = { new Point(350, 100), new Point(375, 125), new Point(375, 150), new Point(375, 175), new Point(350, 200) };

            // fill polygon parameters: brush type, then point array
            G.FillPolygon(SB, PApoints2);
        }
    }
}
