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
// added L63
using System.Diagnostics;

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
            // L60 instance of OpenFileDialog
            OpenFileDialog IOFD = new OpenFileDialog();

            // L60 check 'if' the instance makes the path
            if (IOFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("IOFD Functional, file selected");
            }
            /*
            // L64 Process class, Get Processes, gets all running processes
            //Process.GetProcesses();

            label1.Text += "\n";
            // L64 foreach to get individual proccesses in GetProcesses array
            foreach (Process pEachProcess in Process.GetProcesses())
                //MessageBox.Show(pEachProcess.ProcessName)
                //label1.Text += (" \n" + pEachProcess.ProcessName);

                // kill, (shut down) all processes
                //pEachProcess.Kill();

                // check to see if process is responding, running correctly
                //label1.Text += (" \n" + pEachProcess.ProcessName + ":  " + pEachProcess.Responding.ToString());

                // kill not True process (process not working)
                //if(!pEachProcess.Responding)
                    //pEachProcess.Kill();

                */
            /*
        // L64 GetProcessesByName, get all of the processes of a requested process name
        foreach (Process pProcessByName in Process.GetProcessesByName("chrome"))
            label1.Text += (" \n" + pProcessByName.ProcessName + ":  " + pProcessByName.Responding.ToString());
            */

            // Not in lesson, task manager wanna be
            foreach (Process pEachProcess in Process.GetProcesses())
                listBox1.Items.Add(pEachProcess.ProcessName);

        listBox1.Sorted = true;


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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
