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
// added L63
using System.Diagnostics;
// added L69
using System.Threading;
// added L72
using System.Net;



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
            // L73create save file dialog box to open for browsing
            SaveFileDialog ISFD = new SaveFileDialog();

            // L73 check that user has made a selection using dialog window
            if (ISFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                // L73 create a new class of WebClient
                WebClient CWC = new WebClient();

                // L73 download small file in background using method downloadfile assync, 
                // using new Uri (URL), DownloadFileAsync second parameterwhere to store downloaded file
                //CWC.DownloadFileAsync(new Uri("https://pastebin.com/raw/bTcRK3Ab"), ISFD.FileName);

                // L73 larger file to see download progress  change
                CWC.DownloadFileAsync(new Uri("https://pastebin.com/raw/Jwfa1ynH"), ISFD.FileName);

                // L73 event triggers downloaded file completed message
                CWC.DownloadFileCompleted += CWC_DownloadFileCompleted;

                // L73 display download progress, press tab twice after typing += to generate the rest
                CWC.DownloadProgressChanged += CWC_DownloadProgressChanged;

                }
            // button2 starts disabled and is used to clear button1
            button2.Enabled = true;
        }

        // L73 generated for CWC.DownloadProgressChanged += CWC_DownloadProgressChanged;
        private void CWC_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // generated for download progress then commented out
            //throw new NotImplementedException();

            // show progress completed of download in label1
            //label1.Text += "download progress: " + e.ProgressPercentage.ToString();
            progressBar1.Value = e.ProgressPercentage;
        }

        // L73 generated by VS when CWC.DownloadFileCompleted += CWC_DownloadFileCompleted; 
        private void CWC_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
            // L73 was generated by VS so we could comment out and inject our Messagebox message
            //throw new NotImplementedException();

            // L73 inform user when download it complete
            MessageBox.Show("download completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
            button1.Enabled=true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            // L72 create new class of WebClient() to run client when form1 is loaded
            WebClient cWC = new WebClient();

            // L72 textBox1 to the contents where the DownloadString points you
            textBox1.Text = cWC.DownloadString("https://68ff5456-e6e4-4e8a-bf45-b7914fd680aa.usrfiles.com/ugd/68ff54_e1be3db1a21e40109c3f48cae31f0710.txt");
            //textBox1.Text = cWC.DownloadString("https://pastebin.com/raw/CufQ9tfb");
            
            // start new line for when button1 is clicked
            textBox1.AppendText("" + "\r\n");
            */
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //tWrite.Abort();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
