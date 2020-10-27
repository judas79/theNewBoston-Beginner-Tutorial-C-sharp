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
        // L163 optional parameter, overloading parameters
        private void button1_Click(object sender, EventArgs e)
        {
            // L166 use method to show message, oer title, or both
            showMessage("message!", "title!");
            showMessage("message!");
            showMessage("", "title!");

            // L166 use method optionalMessage() to pass in message2, but not title2
            // the default value, from the optionalMessage(), will be diplayed for title2
            optionalMessage("message2!");

            // L166 provide a value to pass for title2 overides Default Value
            optionalMessage("message2!", "title2!");

            // L166 pass in the regualar parameter then the overloaded optional parameters for title2, and amount
            optionalMessage("message2!", "this should open four times", 4);

            // L166 only pass in regular parameter, message2, and the title1 parameter
            optionalMessage("message2!", "This should open up once");

        }

        // L166 overload methods' copied from method below,
        void showMessage(string message)
        {
            // L166 mesageBox to pass in sting message, and string title
            MessageBox.Show(message);
        }

        // L166 overload methods' arguements as optional parameter, for a messageBox
        void showMessage(string message, string title)
        {
            // L166 mesageBox to pass in sting message, and string title
            MessageBox.Show(message, title);
        }
        
        // L166 overload methods' arguements  optional parameter, for a messageBox, we added the int amount later
        void optionalMessage(string message2, string title2="Default Value", int amount=1)
        {
            // L166 This will make the amount of message boxes, by what is the default value '0'
            // or what we pass in for amount, in our button1 call
            for (int i = 0; i < amount; i++)
            // L166 mesageBox to pass in sting message, and string title
            MessageBox.Show(message2, title2);
        }
    }
}
