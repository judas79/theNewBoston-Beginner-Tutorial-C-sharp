using System;
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
    public partial class Form2 : Form
    {
        // pass string, using constructer, to other Forms
        public Form2(string sMyString, int sIntString)
        {
            InitializeComponent();
            label1.Text = sMyString + sIntString;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
