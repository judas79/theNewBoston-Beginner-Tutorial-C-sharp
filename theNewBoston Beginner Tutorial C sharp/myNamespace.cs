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
        // L20 public class
        string Name;
        public myClass(string name)
        {
            Name = name;
        }

        // public sting, can be used outside of this class document
        public string name()
        {
            return Name;
        }
        
        // public static method, can be used outside of this class document without creating an instance
        // we could of used another string, but used a bool, make sure to convert bool TF to string to Show.
        public static void Showmessage(bool TF)
        {
            System.Windows.Forms.MessageBox.Show(TF.ToString());
        }
    }
}
