﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// added L20
using myNamespace;

// L19 renamed from theNewBoston_Beginner_Tutorial_C_sharp
namespace myNamespace
{
    // L19 sub namespace
    namespace mySubnamespace
    {

    }
    class myClass
    {
        // L25
        public string myName = "Adam";
        private int myAge = 18;
        // L25 now only accessable through the derived class, but not here in the base class
        protected int myWeight = 205;
        public void showMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }    
    }

    // L25 inherit fron myClass
    class mySecondClass : myClass
    {
        // L25 add local member to mySecondClass
        public string hairColor = "brown";
        
        // L25 add method for inherited member
        public void messageboxSpecial()
        {
            // L25 display from inherited member, myWeight using base.
            System.Windows.Forms.MessageBox.Show(base.myWeight.ToString());

            // L25 use base. to display myName in messageboxSpecial
            base.showMessage(base.myName);
        }
        // L25 overwrite base class showMessage message with "my title" using 'new' and appending with 'my title'
        public new void showMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "my title");
        }
    }
}
