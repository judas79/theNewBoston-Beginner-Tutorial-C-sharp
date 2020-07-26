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

        private void button1_Click(object sender, EventArgs e)
        {
            // L79 new name instance for openfiledialog
            OpenFileDialog nOFD = new OpenFileDialog();

            // L79 confirm user has selected a file
            if (nOFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // L79 set users selected image using nOFD, to the name that was chosen
                //pictureBox1.ImageLocation = nOFD.FileName;

                // L79 another way to get selected image using nOFD, from the name that was chosen
                Image imPicture = Image.FromFile(nOFD.FileName);

                // L79 display imPicture in pictureBox1 using Image variable
                pictureBox1.Image = imPicture;
                 
                // show image file name in label1
                string stImageName = nOFD.SafeFileName;
                label1.Text = stImageName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        // display picture from url in pictureBox2, using ImageLocation and url
        pictureBox2.ImageLocation = "https://lh3.googleusercontent.com/proxy/co48KphBdiUKP7BbhalRoicXXlVOoBnuO_CYLTYWCJryJOfejoCEtKjb2rqAqEKjpPWUazRWBlEWIacshqQ4LBdfC19kW4yvrcSZovvwyWQCIsgd_mpDjws";
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
