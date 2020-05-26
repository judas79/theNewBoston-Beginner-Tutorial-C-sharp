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
            int a = 1;
            int b = 2;
            MessageBox.Show(a+" + " + b + " = "+ (a+b).ToString());
            MessageBox.Show((a + b).ToString());

            MessageBox.Show(a + " - " + "5" + " = " + (a - 5).ToString());
            MessageBox.Show(a + " - " + b + " = " + (a - b).ToString());
            MessageBox.Show(a + " * " + b + " = " + (a * b).ToString());
            MessageBox.Show(b + " / " + a + " = " + (b / a).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 5;
            int j = 7;
            MessageBox.Show("int i = " + i.ToString());
            i = i + 10;
            MessageBox.Show("i + 10 = " + i.ToString());
            MessageBox.Show("if i = " + i.ToString());
            i += 10;
            MessageBox.Show("then i += 10 = " + i.ToString());
            MessageBox.Show("if i = " + i.ToString());
            i += i;
            MessageBox.Show("then i += i = " + i.ToString());
            MessageBox.Show("int i = " + i.ToString());
            i -= i;
            MessageBox.Show("then i -= i = " + i.ToString());

            MessageBox.Show("int j = " + j.ToString());
            j *= j;
            MessageBox.Show("then j *=  j = " + j.ToString());
            MessageBox.Show("if j = " + j.ToString());
            j /= j;
            MessageBox.Show("then j /=  j = " + j.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 4;
            MessageBox.Show("int k = " + k.ToString());
            MessageBox.Show("then k-- then k = " + (k--).ToString());
            k = 4;
            MessageBox.Show("if k = " + k.ToString());
            MessageBox.Show("then --k then k = " + (--k).ToString());
            k = 4;
            MessageBox.Show("if k = " + k.ToString());
            MessageBox.Show("then k++ = " + (k++).ToString());
            k = 4;
            MessageBox.Show("if k = " + k.ToString());
            MessageBox.Show("then ++k = " + (++k).ToString());
            k = 4;
            MessageBox.Show("the same outcome if the math is done on its own line".ToString());
            MessageBox.Show("int k = " + k.ToString());
            --k;
            MessageBox.Show("if --k then k = " + k.ToString());
            k = 4;
            MessageBox.Show("int k = " + k.ToString());
            k--;
            MessageBox.Show("if k-- then k = " + k.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool myBool = false;

            if (!myBool)
            {
                MessageBox.Show("myBool is False");
            }
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
