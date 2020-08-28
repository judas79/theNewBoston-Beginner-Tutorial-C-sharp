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

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            // L118 enable user to drop any kind of data on Panel using the 'e' event effect
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            // L118 use 'e' event, GetData method to get the data of the path of the dropped in file
            // to see string contents, we convert it to a string array (SAfile)
            string[] SAfile = e.Data.GetData(DataFormats.FileDrop) as string[];

            int i = 1;
            // iterate through string array SAfile, to get file paths and display in messagebox
            foreach(string s in SAfile)
            {
                MessageBox.Show("File Path ="+ s, "Path "+ i.ToString());
                i++;
            }
        }
    }
}
