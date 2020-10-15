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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L148 Create instances for item1 and item2, and assign a value to each
            Item item1 = new Item();
            Item item2 = new Item();
            item1.iPrice = 4;
            item2.iPrice = 5;

            // L148 add item1 and item2 prices, in our 'public static Item operator + (Item i1, Item i2)', to create item3 instance
            Item item3 = item1 + item2;

            // L148 display item3 Price value in messagebox, converted from int.
            MessageBox.Show(item3.iPrice.ToString());
        }
    }
}
