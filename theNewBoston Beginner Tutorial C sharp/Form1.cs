using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// added L20
using myNamespace;
// added L36 for StreamReader
using System.IO;
// added L63
using System.Diagnostics;

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

            // L66 short var, not it, inverted 
            //short sMyShort = ~3;

            // L66 Converts sMyshort binary ',2' to string
            //MessageBox.Show(Convert.ToString(sMyShort, 2));

            // L67 use and operator to compare both numbers 
            // in the short in a bitwise level to get 1
            short sMyShort = 3 & 5; // 011 & 101 = 001

            // Converts sMyshort binary ',2' to string
            MessageBox.Show(Convert.ToString(sMyShort, 2), "& And operator");

            // L67 use and & operator to compare both numbers 
            // in the short in a bitwise level to get 1
            short sMyShort2 = 3 & 4; // 011 & 100 = 000

            // Converts sMyshort binary ',2' to string
            MessageBox.Show(Convert.ToString(sMyShort2, 2), "& And operator");



            // L67 use or | operator to compare both numbers 
            // in the short in a bitwise level to get 110 = d6
            short sMyShort3 = 3 | 5; // 011 & 101 = 110

            // Converts sMyshort binary ',2' to string
            MessageBox.Show(Convert.ToString(sMyShort3, 2), "Or | operator");


            // L67 use or | operator to compare both numbers 
            // in the short in a bitwise level to get 1
            short sMyShort4 = 3 | 4; // 011 & 100 = 111

            // Converts sMyshort binary ',2' to string
            MessageBox.Show(Convert.ToString(sMyShort4, 2), "Or | operator");


            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
