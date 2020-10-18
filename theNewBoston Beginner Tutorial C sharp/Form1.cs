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
            // L153 int
            int Age = 3;

            // L153 string name, null value is ok
            string name;

            // L153 does not change Age (above), makes duplicate of agePassed
            // to use ref to change value of Age we add ref into the arguements
            // to change value of name we add out to our Modify arguements
            //Modify(Age);
            Modify(ref Age, out name);
            //Modify(6);
            // L153 either: Modify(Age); or Modify(6); Age will still = 3

            // L153 show our values for Age and name in messagebox
            MessageBox.Show("Age = " + Age.ToString() + "  :: " + "name = " + name);
        }

        // L153 method to return age, and pass age int
        // add ref to our arguements to change value of Age
        //void Modify(int agePassed)
        void Modify(ref int agePassed, out string Name)
        {
            agePassed += 5;
            Name = "Adam";
        }
    }
}
