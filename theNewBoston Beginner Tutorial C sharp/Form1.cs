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
        // L97 pass in s from Program.cs
        public Form1(string s)
        {
            InitializeComponent();
            // L97 show contnet of s (the file being opened path)
            MessageBox.Show(s);
        }
    }
}


