using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// L75 net namespace
using System.Net;

// L75 for email
using System.Net.Mail;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L78 Get the values from datetimepicker (date and time)
            DateTime dDT = dateTimePicker1.Value;
            MessageBox.Show(dDT.ToString());

            var date = DateTime.Now;
            var vHour = date.Hour;
            var vMinute = date.Minute;
            var vSecond = date.Second;
            var vTotalSeconds = (vSecond + (vMinute * 60) + (vHour * 3600));
            MessageBox.Show("Hour - " + vHour + "\r\nMinute- " + vMinute + "\r\nSecond- " + vSecond + "\r\nTotal Seconds- " + vTotalSeconds, "Time in Seconds");

            vHour = vTotalSeconds / 3600;
            var vMod = vTotalSeconds % 3600;
            vMinute = vMod / 60;
            vSecond = vTotalSeconds - ((vHour * 3600) + (vMinute * 60));
            MessageBox.Show("Hour - " + vHour + "\r\nMinute- " + vMinute + "\r\nSecond- " + vSecond, "back to HH MM SS");
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
