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
    class myClass
    {   
        // L32 create public keyword event, delegate to return  what parameter passed
        // to subscriber method, handle the event parameter, event method name
        public event EventHandler OnPropertyChanged;

        // L32 create empty var string name
        string name = "";

        // L32 create public string property55
        public string Name
        {
            get { return name; }
            set
            {
                name = value;

                // L32 to raise the event and pass to 'this' (myClass)
                // pass no event information EventArgs()
                OnPropertyChanged(this, new EventArgs());
            }
            
        }
    }
}

