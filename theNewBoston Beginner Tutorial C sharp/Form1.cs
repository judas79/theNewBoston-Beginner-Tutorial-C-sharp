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
// added L36 for StreamReader
using System.IO;



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
            // L36 instanc of openfildialog
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // create instance of streamReader, and give it a file to open 
                // and read, using a (path) or useing ofd to access the openfiledialog class filename
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));

                // to read a streams text file, ReadToEnd method 
                // sr.ReadToEnd();
                // to read all the Text file into a textbox1
                // L37 disabled because we can't display this example at the same time with the following example, causes an error
                //textBox1.Text += sr.ReadToEnd();

                // dispose of the 'stream', used to get this file
                // L37 disabled because we can't display this example at the same time with the following example, causes an error
                //sr.Dispose();

                // Tutorial 37 starts here:
                // L37 instance sr, BaseStream, ReadByte(), byte number goes in parenthesis. Output in base 10
                //textBox1.Text += sr.BaseStream.ReadByte().ToString();  // L37 disabled, go to next example
                //sr.Dispose();

                // L37 instance sr, BaseStream, ReadByte(), byte number goes in parenthesis, 
                // "X" in ToString field makes the output in hexadecimal
                //textBox1.Text += sr.BaseStream.ReadByte().ToString("X");  // L37 disabled, go to next example
                //sr.Dispose();

                /*
                // L37 create byte array (buffer), empty byte array (buffer), three bytes in length
                byte[] buffer = new byte[3];

                // instance sr (StreamReader) to open document, 
                // put one byte in, buffer,starting byte 0 (at begining), read one at a time for bytes 0-2
                sr.BaseStream.Read(buffer, 0, 2);

                // clear textbox1 before every use and re-use 
                // as not to have to re-start, for every document
                textBox1.Text = string.Empty;

                // loop through the buffer, getting one byte per pass,
                // put the byte in myByte
                foreach (byte myByte in buffer)
                {
                    // display the current myByte in textBox1 as hexadecimal, with a space between bytes
                    textBox1.Text += (myByte.ToString("X")+" ");  // L37 disabled, go to next example
                    sr.Dispose();
                }
                */
                /*
                // NOT in this tutorial and messy, needs work!
                // L37 create byte array (buffer), empty byte array (buffer), 15 bytes in length
                byte[] buffer = new byte[0x0f];

                // instance sr (StreamReader) to open document, 
                // put one byte in, buffer, start at byte two (the third byte), and do this for 4 bytes 
                sr.BaseStream.Read(buffer, 0x02, 3);

                // clear textbox1 before every use and re-use 
                // as not to have to re-start, for every document
                textBox1.Text = string.Empty;

                // loop through the buffer, getting one byte per pass,
                // put the byte in myByte
                foreach (byte myByte in buffer)
                {
                    // display the current myByte in textBox1 as hexadecimal, with a space between bytes
                    textBox1.Text += (myByte.ToString("X") + " ");  // L37 disabled, go to next example
                    sr.Dispose();
                }
                */

                // L37 set offset starting position, to read bytes from document
                sr.BaseStream.Position = 0x0A;

                // L37 create byte array (buffer), empty byte array (buffer), three bytes in length
                byte[] buffer = new byte[3];

                // instance sr (StreamReader) to open document, 
                // put one byte in, buffer, start byte 0 beginning, read bytes 0-2 one at a time
                sr.BaseStream.Read(buffer, 0, 2);

                // clear textbox1 before every use and re-use 
                // as not to have to re-start, for every document
                textBox1.Text = string.Empty;

                // loop through the buffer, getting one byte per pass,
                // put the byte in myByte
                foreach (byte myByte in buffer)
                {
                    // display the current myByte in textBox1 as hexadecimal, with a space between bytes
                    textBox1.Text += (myByte.ToString("X") + " ");  // L37 disabled, go to next example
                    sr.Dispose();
                }
            }
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

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
