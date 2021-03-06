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
            string myName = "Adam";

            // set string to cloned object myName, convert object to (string)
            string cloned_myName = (string)myName.Clone();

            MessageBox.Show("cloned_myName =" + cloned_myName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // instance of MyClass, example string
            MyClass MC = new MyClass();

            // set Adam as the classname string in our MyClass class
            MC.className = "Adam";

            // clone Myclass as object, its string name and its value
            MyClass CMCfirstName = (MyClass)MC.Clone();

            // messagebox to show that MyClass is cloned as CfirstName
            MessageBox.Show("CMCfirstName = " + CMCfirstName.className);
        }
    }
    // inherit ICloneable to use its Clone method
    class MyClass : ICloneable
    {
        public string className
        {
            get;
            set;
        }
        // setup Clone method
        public object Clone()
        {
            return this;
        }
    }
}
