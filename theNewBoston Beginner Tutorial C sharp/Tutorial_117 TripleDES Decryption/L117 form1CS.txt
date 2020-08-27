using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// L115 MD5 SHA1 namespace
using System.Security.Cryptography;

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
            // L115 instance of MD5CryptoServiceProvider class
            MD5CryptoServiceProvider Imd5csp = new MD5CryptoServiceProvider();

            // L115 instance of UTF encoding class to create string byte array
            UTF8Encoding Iutfe = new UTF8Encoding();

            // L115 compute MD5 hash using instance Imd5csp
            // convert textBox1 text to bytes and store as Iutfe
            // turn those bytes into a hash, then convert back to string and dipaly in textBox3
            textBox3.Text = BitConverter.ToString(Imd5csp.ComputeHash(Iutfe.GetBytes(textBox1.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L115 create instance of our SHA1CrptoServiceProvider
            SHA1CryptoServiceProvider Isha5csp = new SHA1CryptoServiceProvider();

            // L115 instance of UTF encoding class to create string byte array
            UTF8Encoding Iutfe = new UTF8Encoding();

            // L115 compute SHA1 hash using instance Isha5csp
            // convert textBox2 text to bytes and store as Iutfe
            // turn those bytes into a hash, then convert back to string and dipaly in textBox4
            textBox4.Text = BitConverter.ToString(Isha5csp.ComputeHash(Iutfe.GetBytes(textBox3.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // L117 byte array to hold encyted data
        byte[] Bytencrypted;

        private void button3_Click(object sender, EventArgs e)
        {
            // L115 instance of MD5CryptoServiceProvider class
            MD5CryptoServiceProvider Imd5csp = new MD5CryptoServiceProvider();

            // L115 instance of UTF encoding class to create string byte array
            UTF8Encoding Iutfe = new UTF8Encoding();

            // L116 instance of TripleDES encoding class
            TripleDESCryptoServiceProvider Itdescsp = new TripleDESCryptoServiceProvider();

            // L116 create TripleDES key from text entered in textbox5, and converted to MD5 16 byte hash
            Itdescsp.Key = Imd5csp.ComputeHash(Iutfe.GetBytes(textBox5.Text));

            // L116 these both have to be set for the encyption to work
            // the cipher mode ECB is vulnurable to attacks since like blocks are alike, not recommended
            Itdescsp.Mode = CipherMode.ECB;

            // L116 padding for empty spaces pkcs7  sequential bytes
            Itdescsp.Padding = PaddingMode.PKCS7;

            // L116 instance of ICyptoTransform encryptor interface,
            // using our instance of our TripleDESCryptoServiceProvider
            ICryptoTransform Iict = Itdescsp.CreateEncryptor();

            // L116 TransformFinalBlock, encrypts selected region, parameters:  (UTF8Encoding instance getBytes from textBox6
            // set begining offset to 0, Get all bytes to the end of the length of textbox6)
            // use instance of UTF8Encoding 'Iutfe' to encode TransformFinalBlock
            // Bit convert to string all of the above, display in textbox7
            //textBox7.Text = BitConverter.ToString(Iict.TransformFinalBlock(Iutfe.GetBytes(textBox6.Text), 0, Iutfe.GetBytes(textBox6.Text).Length));

            // L117 hold byte value of enctypted data
            Bytencrypted = Iict.TransformFinalBlock(Iutfe.GetBytes(textBox6.Text), 0, Iutfe.GetBytes(textBox6.Text).Length);

            // L117 alternative way of displaying encrypted data in textBox7 using byte array Bytencrypted
            textBox7.Text = BitConverter.ToString(Bytencrypted);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // L115 instance of MD5CryptoServiceProvider class
            MD5CryptoServiceProvider Imd5csp = new MD5CryptoServiceProvider();

            // L115 instance of UTF encoding class to create string byte array
            UTF8Encoding Iutfe = new UTF8Encoding();

            // L116 instance of TripleDES encoding class
            TripleDESCryptoServiceProvider Itdescsp = new TripleDESCryptoServiceProvider();

            // L117 create TripleDES key from text entered in textbox8, and converted to MD5 16 byte hash
            Itdescsp.Key = Imd5csp.ComputeHash(Iutfe.GetBytes(textBox8.Text));

            // L116 these both have to be set for the encyption to work
            // the cipher mode ECB is vulnurable to attacks since like blocks are alike, not recommended
            Itdescsp.Mode = CipherMode.ECB;

            // L116 padding for empty spaces pkcs7  sequential bytes
            Itdescsp.Padding = PaddingMode.PKCS7;

            // L117 instance of ICryptoTransform decryptor interface, 
            // using our instance of our TripleDESCryptoServiceProvider
            ICryptoTransform Iict = Itdescsp.CreateDecryptor();    

            // L117 TransformFinalBlock, decrypts selected region, parameters:  (UTF8Encoding instance getBytes from textBox9
            // set begining offset to 0, Get all bytes to the end of the length of textbox9)
            // use instance of UTF8Encoding 'Iutfe' to encode TransformFinalBlock
            // store it in the byte array Bytencrypted
            byte[] Bdecrypted = Iict.TransformFinalBlock((Bytencrypted), 0,(Bytencrypted).Length);


            // NOT in lesson see what bitconvert does to our byte array
            MessageBox.Show(BitConverter.ToString(Bdecrypted), "Bdecrypt BitConverter.ToString");

            // NOT IN LESSON UTF encode our decrypted byte array and save to string
            string Sdecrypted = Iutfe.GetString(Bdecrypted);

            // L117 alternative way of displaying encrypted data in textBox7 using byte array Bytencrypted
            textBox10.Text = Sdecrypted;
        }
    }
}
