using System;
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
            string[] stringName = new string[2]; // "", ""
            try
                {
                string subName = stringName[2];
                }
            
            catch(Exception ex)
            {
                textBox1.Text += "an exception has occured ";
                MessageBox.Show("smaller error message! \n\n" + ex.Message);
                MessageBox.Show("larger error message! \n\n"  + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try{
                string[] stringName = new string[2]; // "", ""
                string subName1 = stringName[0];
                //string subName = stringName[2];
            }
            
            catch (Exception ex)
            {
                textBox1.Text += "an exception has occured ";
                MessageBox.Show("smaller error message! \n\n" + ex.Message);
                MessageBox.Show("larger error message! \n\n" + ex.ToString());
            }
            finally
            {
                MessageBox.Show("finally");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 10;
            do
            {
                textBox3.Text += i.ToString() + ", ";
                --i;
            }
            while (i >= 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> integerList = new List<int>();
            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);
            foreach (int i in integerList)
                MessageBox.Show("this is item #" + i, "Title" + i);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int c = 0;

            if (b>1)
            {
                MessageBox.Show("b is greater than a");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int c = 0;

            if (b != 4)
            {
                MessageBox.Show("b is not equal to 4");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int c = 0;

            if (5 >= c)
            {
                MessageBox.Show("5 is greater than or equal to " + c);
            }
        }
    }
}
