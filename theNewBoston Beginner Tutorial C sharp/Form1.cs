﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDLL.Clients;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // L140 exit FlashScreen and any other forms, other than Form1
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L141 add instance of Clients (MyDLL.Clients;
            Client Ic = new Client();

            // L141 add name and age values for the Clients properties
            Ic.sName = "Roddy";
            Ic.iAge = 59;

            //  not in lesson, view results.
            MessageBox.Show("Name is: \t" + Ic.sName + "\nAge is: \t" + Ic.iAge );
        }
    }
}
