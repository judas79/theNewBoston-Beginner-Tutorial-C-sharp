#define Adam
#undef Adam
#define Bob
#undef Bob
#define Mark
//#define Jack
//#undef Jack
// L179 write #define and #undef, before everything, above
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // L179 using #region and #endregion to hide code
            #region Region 1 variables
            int iNumber = 1;
            string sNoun = "car";
            #endregion

            // L179 use if statement with #define symbol
            // L179 if the if statement is true, send message
            // L179 endif, end the #if statement
#if Adam
            MessageBox.Show("Adam is a defined symbol");

            // NOT in lesson, another #if statement, add #define Jack at top, requires another #endif
            // this makes all defines not function, do not use two #if statements
//#if Jack
            //MessageBox.Show("Jack is a defined symbol");

            // L179 #elseif statement with message not executed if true; stops because Adam is true
#elif Bob
            MessageBox.Show("Bob is a defined symbol");

            // L179 #elif to show how to throw an error instead of a messageBox

#else
            MessageBox.Show("there are no defined symbol");
#endif
//#endif
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L179 throw an error or warning #if Adam is found to be a symbol
#if Mark
//#error Mark is defined  // this will not work at all! or compile until commented out
#endif //Mark
        }
    }
}