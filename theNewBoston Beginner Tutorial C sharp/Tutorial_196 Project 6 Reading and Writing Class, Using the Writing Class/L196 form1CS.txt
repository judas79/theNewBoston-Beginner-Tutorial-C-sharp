using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByteOrderInOut;

namespace ByteOrderIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L191 open a file dialog to choose a file to read, verify that a file has been opened
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // L191 create instance of our Reader, from our namespace ByteOrderInOut;
                Reader R = new Reader(OFD.FileName);

                // L196 clear hex output from textbox1
                textBox1.Text = "";

                // L191 Read an int 32, convert it to hexadecimal string  Adam == 41 61 64 6D hex.
                //MessageBox.Show(R.ReadInt32().ToString("X"));
                // L196 Read an int 32, convert it to hexadecimal string  Adam == 41 61 64 6D hex.
                textBox1.Text = R.ReadInt32().ToString() + " = " + R.ReadInt32().ToString("X");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // L196 create instance of our Writer, from our namespace ByteOrderInOut;
                Writer W = new Writer(OFD.FileName);

                // L196 Read text in textbox2 store in string s
                string s = textBox2.Text;

                // L196 write contents of s to file opened in file dialog
                W.WriteUnicode(s);

                // L196 let user know that the unicode was written to file
                MessageBox.Show(textBox2.Text.ToString() + " appended, as unicode to file");

                // L196 clear old input from textbox2
                textBox2.Text = "";

                // L196 close this so something else can be used
                W.WriterClose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // L196 create instance of our Writer, from our namespace ByteOrderInOut;
                Writer W = new Writer(OFD.FileName);

                // L196 Read text in textbox2 store in string s
                string s = textBox3.Text;

                // L196 define the start position to write at
                W.Position = 0x10;

                // L196 write contents of s to file opened in file dialog
                W.WriteUnicode(s);

                // L196 write as little endian
                W.changeByteOrder(BaseIO.byteorder.LittleEndian);

                // L196 define the start position to write at
                W.Position = 0x20;

                // L196 write contents of s to file opened in file dialog
                W.WriteUnicode(s);

                // L196 let user know that the unicode was written to file
                MessageBox.Show("'" + textBox3.Text.ToString() + "' appended, as BigEndian & LittleEndian unicode, to file");

                // L196 clear old input from textbox2
                textBox3.Text = "";

                // L196 close this so something else can be used
                W.WriterClose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // L196 create instance of our Writer, from our namespace ByteOrderInOut;
                Writer W = new Writer(OFD.FileName);

                // L196 Read text in textbox2 store in string s
                //ulong i = UInt64.Parse(textBox4.Text);       // does NOT work
                ulong n = ulong.Parse(textBox4.Text.Replace(" ",""), System.Globalization.NumberStyles.HexNumber);

                // L196 define the start position to write at
                W.Position = 0x30;

                // L196 write contents of s to file opened in file dialog
                W.WriteUlong(n);

                // L196 let user know that the unicode was written to file
                MessageBox.Show("'" + textBox4.Text.ToString() + "' appended, as BigEndian hex, to file");

                // L196 clear old input from textbox2
                textBox4.Text = "";

                // L196 close this so something else can be used
                W.WriterClose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // L196 create instance of our Writer, from our namespace ByteOrderInOut;
                Writer W = new Writer(OFD.FileName);

                // L196 Read text in textbox4 store in byte array s
                byte[] s = ASCIIEncoding.ASCII.GetBytes(textBox5.Text);

                // L196 define the start position to write at
                W.Position = 0x50;

                // L196 write contents of s to file opened in file dialog
                W.WriteBytes(s);

                // L196 write as little endian
                W.changeByteOrder(BaseIO.byteorder.BigEndian);

                // L196 define the start position to write at
                W.Position = 0x60;

                // L196 write contents of s to file opened in file dialog
                W.WriteBytes(s);

                // L196 let user know that the unicode was written to file
                MessageBox.Show("'" + textBox5.Text.ToString() + "' appended, as BigEndian & LittleEndian bytes, to file");

                // L196 clear old input from textbox2
                textBox5.Text = "";

                // L196 close this so something else can be used
                W.WriterClose();
            }
        }
    }
}
