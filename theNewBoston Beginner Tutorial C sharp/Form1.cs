﻿using System;
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
            // L34 create and use a new openfiledialog
            OpenFileDialog ofd = new OpenFileDialog();

            // change default title of open file dialog box
            ofd.Title = "Open Folders & Files";

            // restrict file types that can be opened
            ofd.Filter = "PDF text / image|*.pdf|TXT text|*.txt|YOMOMA ho|*.uho|All Files|*.*";

            // call show dialog to see open dialog
            //ofd.ShowDialog();

            string myFileStatus = "";

            // check to see if file opened or not, OK is an 
            // enumeration used to see if there is something or nothing
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 myFileStatus = "File is Open";

            else myFileStatus = "File did not open";

            MessageBox.Show(myFileStatus,"File Status");

            // get the file path and file name of the file you opened
            MessageBox.Show(ofd.FileName, "File Path and Name");

            // get file name only
            MessageBox.Show(ofd.SafeFileName, "File Name only");
        }

        private void Mc_OnPropertyChanged(object sender, EventArgs e)
        {
            // this was generated by VS but not what we needed
            //throw new NotImplementedException();

            // this message does not change the properties, but notifies us that they have changed
            MessageBox.Show("This was caused by an event, because properties have changed", "Events");
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // to display the returned contents in myMethod3's, static return
            MessageBox.Show(myMethod3());
            textBox3.Clear();
            textBox3.Text += myMethod3();
        }

        // since myMethod3 is a static type not a void type, it now can return a static value
        string myMethod3()
        {
            return "This is a static method";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 234;
            // to display the returned contents in myMethod2's, string name
            MessageBox.Show(myMethod4(i).ToString());
            textBox4.Clear();
            textBox4.Text += myMethod4(i);
        }

        // since myMethod2 is a string type not a void type, it now can return a string value
        int myMethod4(int name4)
        {
            return name4;
        }


    private void button5_Click(object sender, EventArgs e)
        {
            // to display the returned contents in myMethod5's, static return
            MessageBox.Show(myMethod5().ToString());
            textBox5.Clear();
            textBox5.Text += myMethod5();
        }

        // since myMethod3 is a static type not a void type, it now can return a static value
        int myMethod5()
        {
            return 456;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // to display the returned contents in myMethod6's, static return
            MessageBox.Show(myMethod6().ToString());
          
        }

        // since myMethod6 is a static type not a void type, it now can return a static value
        bool myMethod6()
        {
            return false;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            bool b = true;
            MessageBox.Show(trueFalse(b).ToString());
        }

        bool trueFalse(bool state7)
        {
            return state7;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
