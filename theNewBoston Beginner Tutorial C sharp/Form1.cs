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
            // L23 create instance of a class: class name, instance name, equals, 
            // class name, instance name, equals, new, class name, parenthesis, semicolon
            myClass mc = new myClass();

            // L25 creating a instance for inherting class, mySecondClass 
            mySecondClass msc = new mySecondClass();
            MessageBox.Show(msc.myName);
            textBox1.Text += msc.hairColor;


            // L25 this will not work in base class, its protected
            // MessageBox.Show(mc.myWeight);
            msc.showMessage("message portion");


            // L25 show contents (myWeight) which is in public void messageboxSpecial()
            // using instance mc for class mySecondClass
             msc.messageboxSpecial();

            // L26 inheriting from mySecondclass, makes members from both 
            // myClass and mySecondClass available
            myThirdClass mtc = new myThirdClass();

            // L26 display hairColor
            MessageBox.Show(mtc.hairColor);

            // L26 display contents of myVoid
            mtc.myVoid();

            /*
                        // L23 read only example
                        textBox2.Text += mc.readName;

                        // L23 entered
                        mc.readName = "readOnlyName";

                        // L24 set myString to empty to cause exception
                        myClass.CheckString("");
                        myClass.CheckString2("");
            */
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
    }
}
