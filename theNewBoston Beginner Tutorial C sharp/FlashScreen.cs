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
    public partial class FlashScreen : Form
    {
        
        public FlashScreen()
        {
            InitializeComponent();
        }


        // L140 set up timer variable
        Timer tm;
        private void FlashScreen_Shown(object sender, EventArgs e)
        {
            
            // L149 create timer name instance
            tm = new Timer();


            // L140 set time interval to 2 seconds (in Milliseconds)
            tm.Interval = 2000;
            

            // L149 create timer Tick event for it to show, after typing tm.Tick += 
            // double click tab to generate the method below, fill in new EventHandler and put Tm_Tick in parenthesis
            tm.Tick += new EventHandler(Tm_Tick1);
            
        }
        
        // L140 generated when creating the Timer Event (above)
        private void Tm_Tick1(object sender, EventArgs e)
        {
            // L140 we will replace this generated code
            //throw new NotImplementedException();

            // L140 This will stop the spashscreen after the interval is up
            // this will stop the splashscreen from showing
            tm.Stop();

            // L140 create a instance of form1
            Form1 If1 = new Form1();

            // L140 show form1
            If1.Show();

            // L140 hide this splashscreen
            this.Hide();
            this.Visible = false;
        }
    }
}
