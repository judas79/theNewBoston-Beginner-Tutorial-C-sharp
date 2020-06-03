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
            // L20 create instance of a class: class name, instance name, equals, 
            //new, class name, parenthesis, semicolon
            myClass mc = new myClass("myNameGoesHere");

            // L20 accessing the public string name() method to get the return value of Name:
            mc.name();
            MessageBox.Show(mc.name());

            // L21 The code in the form holding the button1 is passed thru the class, into the public static void method, 
            // so it can be displayed use Messagebox to Show 'true'
            myClass.Showmessage(true);

            // L22 In myNamespace.cs class doc, changed var. type 
            // to allow more than one usage of that method name.
            myClass.Showmessage(3);

            // L22 notice the same method name and var type is being used
            // in the myNamespace.cs class a different var name is associated with 
            // this second exxample, of the same method and parameter var type
            myClass.Showmessage(false);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                textBox2.Text += i.ToString();
            }
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
    }
}
