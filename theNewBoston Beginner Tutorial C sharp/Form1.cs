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
            // L91 create new listViewItem to pass in textBox text entered text
            ListViewItem ILV = new ListViewItem(textBox1.Text);

            // add textbox2 and textBox3 to our ListView items, as sub items.
            ILV.SubItems.Add(textBox2.Text);
            ILV.SubItems.Add(textBox3.Text);

            // Add the listview item and subitems to listView
            listView1.Items.Add(ILV);

            // L91 set textBoxes text, all equal to empty strings.
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

    }
}







