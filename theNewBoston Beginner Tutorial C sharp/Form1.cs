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
            // put this int above the instance or no worky
            int iTB2 = Convert.ToInt32(textBox2.Text);

            // L87 create instance of form2, pass string in textBox1 to form2
            Form2 IF2 = new Form2(textBox1.Text, iTB2);

            
            // L87 shows form2 when button1 clicked, toggle selection between windows
            //IF2.Show();

            // L87 shows form2 when button1 clicked, form2 stays at forefront of window
            IF2.ShowDialog();

            // this will hide form1 when form2 is closed; also hides tray icon
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        int iHour;
        int iMinute;
        int iSecond;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string sEnteredTime = maskedTextBox2.Text;
                string[] saTime = sEnteredTime.Split(':');
                iHour = Convert.ToInt32(saTime[0]);
              
                if (iHour > 23)
                {
                    MessageBox.Show("hours must be less than 24");
                    return;
                }
               
                
                iMinute = Convert.ToInt32(saTime[1]);
                if (iMinute > 59)
                {
                    MessageBox.Show("minutes must be less than 60");
                    return;
                }
                iSecond = Convert.ToInt32(saTime[2]);
                if (iSecond > 59)
                {
                    MessageBox.Show("seconds must be less than 60");
                    return;
                }
                textBox2.Text = (iHour + ":" + iMinute + ":" + iSecond);
            }
            catch
            {
                MessageBox.Show("Enter time in military time notation (Hours 1 -24)\r\n" +
                    "Use 0's  example:\r\n23 00 37 = 11:00:37pm");
                return;
            }
            timer1.Start();
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
            iSecond--;
            if (iSecond < 0)
            {
                iMinute--; iSecond = 59;
            }
            if (iMinute < 0)
            {
                iHour--; iMinute = 59;
            }

            if (iSecond >= 0 && iMinute >= 0 && iHour >= 0)
            {
                textBox2.Text = (iHour + ":" + iMinute + ":" + iSecond);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("spam sent");
            }
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
