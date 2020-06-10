﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myNamespace
{
    // L29 partial key
    partial class myClass
    {
        // variable fields
        public string HairColor = "Brown";
        public bool Glasses = false;

        // L29 share method using partial, {providing implimintation}
        partial void Message(string message)
        {   
            // shortcut type m b TAB to create the messagebox pathway
            System.Windows.Forms.MessageBox.Show(message);
        }
        // public void method to display Messages parameter, string message
        public void ShowMessage(string message)
        {
            Message(message);
        }
    }
}
