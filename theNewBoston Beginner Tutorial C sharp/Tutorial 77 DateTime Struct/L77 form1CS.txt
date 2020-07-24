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
            // L77 create new name for datetime struct passing through Y M D
            DateTime NDT = new DateTime(1961, 7, 3, 23, 59, 59);
            MessageBox.Show(NDT.ToString(), "static");

            // L77 create datetime struct "Today" for date without time
            DateTime NDT2 = DateTime.Today;
            MessageBox.Show(NDT2.ToString(), "Today");

            // L77 create datetime 'Now" for date and time
            DateTime NDT3 = DateTime.Now;
            MessageBox.Show(NDT3.ToString(), "Now");

            // L77 Is this() a leap year or not.
            DateTime.IsLeapYear(1987);

            // NOT in lesson
            int iCount = 1;
            int iEndDate = Convert.ToInt32(textBox2.Text);
            for(int iBeginDate = Convert.ToInt32(textBox1.Text); iBeginDate <= iEndDate; iBeginDate++)
            {
                bool bDT = DateTime.IsLeapYear(iBeginDate);
                MessageBox.Show(bDT.ToString(), iCount.ToString() + ". T/F " + iBeginDate.ToString() + " is a Leap Year?");
                iCount++;
            }

            // L77 how any days in a specified month in a defined year
            DateTime.DaysInMonth(1919, 4);

            // NOT in lesson
            int iCount2 = 1;
            int iYear = Convert.ToInt32(textBox3.Text);
            for (int iBeginMonth = Convert.ToInt32(textBox4.Text); iBeginMonth < 13; iBeginMonth++)
            {
                int iDT = DateTime.DaysInMonth(Convert.ToInt32(iYear), Convert.ToInt32(iBeginMonth));
                string[] sMonths = {"", "January", "February", "March", "April", "May", "June", "July", "August","September", "October", "November", "December" };
                MessageBox.Show(iCount2.ToString() + ". There are " + iDT.ToString() + " days in " + sMonths[iBeginMonth] + " .");
                iCount2++;
            }
            
            // L77 convert datetime .Now to hex using .ToFileTime
            MessageBox.Show(DateTime.Now.ToFileTime().ToString("X"), "ToFileTime in hex");

            // L77 use .FromFileTime to convert hex value back into plain text(this did not work)
            //Int64 int_value = Convert.ToInt32("1D661ED89BFE598", 16);
            //DateTime dDT = DateTime.FromFileTime(int_value);        
            //MessageBox.Show(dDT.ToString(), "Convert back to string using FromFileTime");

            // L77 use .FromFileTime to convert base 10 value back into plain text(second try)
            Int64 int_value = DateTime.Now.ToFileTime();
            MessageBox.Show("Decimal value = " + int_value.ToString() + "\r\nHex Value = " + int_value.ToString("X"), "Convert to decimal and hex string using FromFileTime");
            DateTime dDT1 = DateTime.FromFileTime(int_value);
            MessageBox.Show(dDT1.ToString(), "Convert base 10 var from DateTime.Now.ToFileTime() back to string using FromFileTime");


            // NOT in lesson convert back to date time string from dec. copied from clipboard
            // show date time now in hex  
            MessageBox.Show(DateTime.Now.ToFileTime().ToString(), "ToFileTime in base 10");

            // clear the clipboard, to stop win 7 error
            Clipboard.Clear();

            // copy the output in messagebox window to clip board and save to long
            Clipboard.SetText(DateTime.Now.ToFileTime().ToString());

            string sDecText = Clipboard.GetText();
            MessageBox.Show(sDecText, "copied decimal DT value from clipboard");
            Int64 iDecText = Convert.ToInt64(sDecText);

            // Next line, Does not work, error, could not convert from hex to deciaml
            //long sHex = d.ToFileTime();

            DateTime dDT = DateTime.FromFileTime(iDecText);
            MessageBox.Show(dDT.ToString(), "Convert back to string using FromFileTime");
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
