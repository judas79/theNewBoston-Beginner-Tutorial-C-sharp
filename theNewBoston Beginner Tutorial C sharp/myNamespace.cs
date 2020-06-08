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
        // L27 string access modifier,
        public string this[int index]
            {
            // return the index passed through stringArray and 
            // index what is passed through the [index] parameter
            get { return stringArray[index]; }

            // index number value determines which stringArray item is selected
            set { stringArray[index] = value; }
            }
        // L27 indexers, string array 3 items
        string[] stringArray = {"Bob", "Carol", "Alice"};

    }
}

