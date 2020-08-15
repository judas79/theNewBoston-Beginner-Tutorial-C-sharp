﻿using System;
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L105 navigate method displays page in webBrowser1,
            // after getting address from textBox1
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // L105 webBrowser class get current url converts it to string
            // display url in the webpage address box
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L105 go back to the prior web address in your browser, class webBrowser1 goBack method
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // L105 reload the page you are on, class webBrowser1 Refresh method
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // L105 go to the web address you where at before going back in your browser, 
            // class webBrowser1 goBack method
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // L105 go to the web address homepage set by the MS browser
            // class webBrowser1 gohome method
            webBrowser1.GoHome();
        }
    }
}
