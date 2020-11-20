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

        private void button3_Click(object sender, EventArgs e)
        {
            string test = "   The Bus    ~";
            string Scar = "car";
            int iNum = 22;
            int iNum2 = 53;
            int iSum = iNum + iNum2;
            int iDiv;

            Console.WriteLine(test.StartsWith("T"));
            Console.WriteLine(test.EndsWith(" Bus"));
            Console.WriteLine(test.Contains("s"));
            Console.WriteLine(test.Replace(" ", "-"));
            Console.WriteLine(test.Trim());
            Console.WriteLine(test.TrimEnd());
            Console.WriteLine(test.TrimStart());

            Console.WriteLine($"The {Scar} went {test} yes {iNum}");
            MessageBox.Show($"The {Scar} went {test} yes {iNum}- int didn't need to be converted ToString()");

            Console.WriteLine($"iNum + iNum2 = {iSum}");
            Console.Write($"Divide iNum2 / iNum = {iDiv = iNum2 / iNum}:  ");
            Console.WriteLine("WriteLine to next line, then \\n to skip another line \n");
            Console.WriteLine($"Divide iNum2 / iNum then to get remainder as decimal iDiv = (iNum2 % iNum)/ iDiv = {iDiv = iNum2 / iNum}.{iDiv = (iNum2 % iNum) / iDiv}");
            MessageBox.Show($"iNum + iNum2 = {iSum}");


            bool bMath = iNum + iNum2 > 10;
            if (bMath) Console.WriteLine($"iNum + iNum2 = {iSum} which is greater than 10:  {bMath}");

            var vNames = new List<string> { "zero", "one", "two", "three" };  // is the same as
            //List<string> vNames = new List<string> { "zero", "one", "two", "three" };
            vNames.Add("four");
            vNames.Add("6");
            foreach (var Name in vNames)
            {
                Console.WriteLine(Name);
            }

            var indexName = vNames.IndexOf("four");
            Console.WriteLine($"index number for 'four' is:  {indexName}");

            vNames.Sort();
            foreach (var Name in vNames)
            {
                Console.WriteLine(Name);
            }
            
            
            //var vFibonacchi = new List<int> { 1 ,1 };  // is the same as
            List<int> vFibonacci = new List<int> { 1, 1 };
            
            for (int i = 1; i < 19; i++)
            {
                var vPrevious = vFibonacci[vFibonacci.Count - 1];
                var vPrevious2 = vFibonacci[vFibonacci.Count - 2];
                vFibonacci.Add(vPrevious2 + vPrevious);
            }
            int j = 1;
            foreach (var vItem in vFibonacci)
            {
                Console.WriteLine($"{j}. {vItem}");
                j++;
            }
            
            j = 1;
            while (vFibonacci.Count < 20)
            {
                var vPrevious = vFibonacci[vFibonacci.Count - 1];
                var vPrevious2 = vFibonacci[vFibonacci.Count - 2];
                vFibonacci.Add(vPrevious + vPrevious2);
            }
            j = 1;
            foreach (var vItem in vFibonacci)
            {
                Console.WriteLine($"{j}. {vItem}");
                j++;
            }
        }
    }
}