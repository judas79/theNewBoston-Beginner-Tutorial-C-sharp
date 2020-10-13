﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            // L145 instance of bitmap with width and length overloads, using Screen class,
            // Primary Screen (screen that has taskbar), WorkingArea(the whole screen) width, heigth properties
            Bitmap btmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            // L145 instance of graphics, from the screen capture image, store it in bitmap
            Graphics grphcs = Graphics.FromImage(btmp);

            // L145 capture screen using graphics, using capture method CopyFromScreen, start from Point.Empty from upper top left of screen
            // Start scaned copy from top left Point.empty, size of screen to capture the width and heigth size
            grphcs.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);

            // L145 display screen shot stored in bitmap by setting it equal to the pictureBox1.Image
            pictureBox1.Image = btmp;
        }

        void blah()
        {
            for(; ; )
            {
                // L145 instance of bitmap with width and length overloads, using Screen class,
                // Primary Screen (screen that has taskbar), WorkingArea(the whole screen) width, heigth properties
                Bitmap btmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

                // L145 instance of graphics, from the screen capture image, store it in bitmap
                Graphics grphcs = Graphics.FromImage(btmp);

                // L145 capture screen using graphics, using capture method CopyFromScreen, start from Point.Empty from upper top left of screen
                // Start scaned copy from top left Point.empty, size of screen to capture the width and heigth size
                grphcs.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);

                // L145 display screen shot stored in bitmap by setting it equal to the pictureBox1.Image
                pictureBox1.Image = btmp;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L145 instance of threading pass in method 'blah'
            Thread thread1 = new Thread(blah);

            // L145 start our thread
            thread1.Start();
        }
    }
}
