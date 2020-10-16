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

        // L148 class, with public int var. property, to get and set
        class Item
        {
            public int iPrice
            {
                get;
                set;
            }
            // L148 the way to overload the operator '+', and return a new Item, (using method between parenthesis)
            public static Item operator + (Item i1, Item i2)
            {
                // L148 define what item 3  is, create item 3 Price by adding i1 + i2, return i3 to get; set; Price
                Item i3 = new Item();
                i3.iPrice = i1.iPrice + i2.iPrice;
                return i3;
            }

            // L149 operator to compare if 2 items are equal, all operators are public static
            // Type of return will be 'bool', tell compiler operator meaning overloading, with equal == operator, 
            // parameters (using method between parenthesis) item left of == item on right ogf the equals comparitor
            public static bool operator ==(Item i1, Item i2)
            {
                // L149 return bool, use ternary operator to determine truth
                return (i1.iPrice == i2.iPrice) ? true : false;
            }
            // L149 operator to compare if 2 items are not equal, all operators are public static
            // Type of return will be 'bool', tell compiler operator meaning overloading, with not equal != operator, 
            // parameters (using method between parenthesis) item left of != item on right ogf the equals comparitor
            public static bool operator !=(Item i1, Item i2)
            {
                // L149 return bool, use ternary operator to determine truth
                return (i1.iPrice != i2.iPrice) ? true : false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L149 instance for each item
            Item item1 = new Item();
            Item item2 = new Item();

            // L149 each items price is 5
            item1.iPrice = 4;
            item2.iPrice = 5;

            // L149 use if statement to see if items are identical or not
            if (item1.iPrice == item2.iPrice) MessageBox.Show("Items are the same");
            else if (item1.iPrice != item2.iPrice) MessageBox.Show("Items are different");
        }
    }
}
