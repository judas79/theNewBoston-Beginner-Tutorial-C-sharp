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
            // L44 instance of SaveFileDialog
            SaveFileDialog iSFD = new SaveFileDialog();

            // L44 save files as a certain file type
            iSFD.Filter = "Text File|*.txt|Document|*.doc";

            //L44 set default filename for file
            iSFD.FileName = "Name Me 'Dame un nombre'";

            // L44 change SaveFileDialog name
            iSFD.Title = "Save as 'Guardar como'";

            // L44 verify if everything is opened properly
            if (iSFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                // L44 string 
                string path = iSFD.FileName;

                // L44 instance to create new file, and choose path
                BinaryWriter iBW = new BinaryWriter(File.Create(path));
                
                // L44 write to file
                iBW.Write("test example");

                // close file properly
                iBW.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
