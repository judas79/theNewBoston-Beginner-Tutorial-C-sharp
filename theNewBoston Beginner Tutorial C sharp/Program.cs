using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()   // original code

        // L97 added a string array to the main to pass to the file being opened
        //static void Main(string[] files)  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // L140 run FlashScreen instead of form1
            Application.Run(new FlashScreen());
            // L97 for each file opened, create a form1, and pass in s to form1
            //foreach(string s in files)
            //Application.Run(new Form1(s));
            //Application.Run(new Form1());


        }
    }
}
