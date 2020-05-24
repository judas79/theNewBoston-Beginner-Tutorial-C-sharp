using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theNewBoston_Csharp_Beginner_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "String code";
            string statement = "Statement goes here";
            string title = "title goes here";
            MessageBox.Show(statement, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 123;
            int number2 = -123;
            MessageBox.Show(number.ToString(), number2.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool boolean = false;
            bool notFalse = true;
            MessageBox.Show(boolean.ToString(), notFalse.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object myString1 = "statement goes here";
            object mybool1 = false;
            object mydecimal1 = 1;
            MessageBox.Show(myString1.ToString(), mybool1.ToString() + " " + mydecimal1.ToString());

        }
    }
}
