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
        // L23 string var for readName in MyClass, read only
        string readOnlyName;

        // L23 constructor, string being past thru
        public myClass(string passThruName)
        {
            propName = passThruName;
            readOnlyName = passThruName;
           
        }
        public string propName
        {
            get;
            private set;
        }
        // L23 read only, everywhere, can't change value of readName
        public string readName
        {
            get { return readOnlyName; }
            set
            {
                if (value != "readOnlyName") System.Windows.Forms.MessageBox.Show("entered name value, not identical");
                else
                    System.Windows.Forms.MessageBox.Show("entered name value confirmed: "+ value, value + " Welcome");
            }
        }
    }
}
