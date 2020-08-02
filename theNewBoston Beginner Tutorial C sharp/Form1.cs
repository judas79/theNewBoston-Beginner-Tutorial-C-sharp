﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// L85 to use wav files
using System.Media;

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
            // L88 inform the compiler a form will be contained within form1
            this.IsMdiContainer = true;

            // L88 create the new form that will reside within form1
            Form Iform2 = new Form();

            // L88 form2 resides within parent, form1
            Iform2.MdiParent = this;

            // shows form2 inside of form1, ShowDialog() will not work
            Iform2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // reset i in button3 for statement to 0
            i = 0;

            // L88 inform the compiler a form will be contained within form1
            this.IsMdiContainer = true;

            // L88 create the new form that will reside within form1
            Form Iform2 = new Form();

            // L88 form2 resides within parent, form1
            Iform2.MdiParent = this;

            // shows form2 inside of form1, ShowDialog() will not work
            Iform2.Show();
            

            // L88 create the new form that will reside within form1
            Form Iform3 = new Form();

            // L88 form2 resides within parent, form1
            Iform3.MdiParent = this;

            // shows form2 inside of form1, ShowDialog() will not work
            Iform3.Show();

            // L88 create the new form that will reside within form1
            Form Iform4 = new Form();

            // L88 form2 resides within parent, form1
            Iform4.MdiParent = this;

            // shows form2 inside of form1, ShowDialog() will not work
            Iform4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        int i;
        private void button3_Click(object sender, EventArgs e)
        {
            // L88 see the 4 mdiLayout types, one after another
            for (i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    this.LayoutMdi(MdiLayout.ArrangeIcons);
                }
                if (i == 1)
                {
                    this.LayoutMdi(MdiLayout.Cascade);
                }
                if (i == 2)
                {
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                }
                if (i == 3)
                {
                    this.LayoutMdi(MdiLayout.TileVertical);
                }
                MessageBox.Show("i = " + i);
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
   
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }
       
        

        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
