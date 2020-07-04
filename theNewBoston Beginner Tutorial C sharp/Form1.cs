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
            // L56 instance of FolderBrowserDialog
            FolderBrowserDialog IFBD = new FolderBrowserDialog();

            // L56 check 'if' the instance makes the path
            if (IFBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("IFBD Functional");

                // L59 create a folder, , messagebox title
                //Directory.CreateDirectory(IFBD.SelectedPath + "//New Sub Folder");

                // NOT IN LESSON, lets you know you created a folder
                MessageBox.Show(Directory.CreateDirectory(IFBD.SelectedPath + "//New Sub Folder").ToString(), "Folder");

                // L59 select folder move and rename
                //Directory.Move(IFBD.SelectedPath, "C:\\Users\\Roddy\\OneDrive\\Documents\\VS Test folder\\New Sub Folder2");
             
            }
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
