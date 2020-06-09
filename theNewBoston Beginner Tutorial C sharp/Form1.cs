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
            // L28 variables for struct example
            // string ClientName = "Peter";
            // int ClientAge = 34;
            Client client1 = new Client();
            // we replace variables above with, an instance of the struct
            // struct name, name, equals, new, struct name, parenthesis, for each client
            // after addin a constructor to our struct we can now add a new client name
            // in the parameter new Client(new name here);  or leave it blank

            Client client2 = new Client();

            // enter first clients name and age
            client1.Name = "Bob";
            client1.Age = 34;
            

            // enter second clients name and age
            client2.Name = "Carol";
            client2.Age = 35;

            // use void method to clearClientInfo
            client2.clearClientInfo();

            // ********** create 3rd client for personal TEST CODE NOT WORKING ************

            // enter second clients name and age
            Client client3 = new Client();
            client3.Name = "Ted";
            client3.Age = 36;

            for (int i = 0; i < 2; i++)
            {
            if (i <= 0)
                {
                MessageBox.Show(client3.Name);
                MessageBox.Show(client3.Age.ToString());
                i++;
                textBox1.Text += "if " + i.ToString();
                }
           
            else
                {
                    
                textBox1.Text += " else " + i.ToString();
                MessageBox.Show(client1.Name);
                MessageBox.Show(client1.Age.ToString());
                i--;
                }
                
            }

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
