using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// added L20
using myNamespace;

// L19 renamed from theNewBoston_Beginner_Tutorial_C_sharp
namespace myNamespace
{
    // L19 sub namespace
    namespace mySubnamespace
    {

    }
    class myClass
    {
        // L22 enumeration integer type array
        enum enumIntNames
        {
            Bob,
            Carol,
            Ted,
        }
        // L22 enumeration integer type array assigned different integers, jack equals 7
        enum enumIntNames2
        {
            John,
            Max,
            Bif = 4,
            Alice = 6,
            Jack,
        }
        // L22 byte array, instead of integer array
        enum enumByteNames : byte
        {
            Carl,
            Axel = 5,
            Spence,
        }

        // L20 public class
        string Name;
        public myClass(string name)
        {
            Name = name;
        }

        // public string, can be used outside of this class document
        public string name()
        {
            return Name;
        }

        // L22 enumeration name, variable enumeration name, equals the enumeration name, dot, item elements
        enumIntNames myNames = enumIntNames.Carol;

        // L21 public static method, can be used outside of this class document without creating an instance
        // we could of used another string, but used a bool, make sure to convert bool TF to string to Show.
        public static void Showmessage(bool TF)
        {
            System.Windows.Forms.MessageBox.Show(TF.ToString());
        }

        // L22 to avoid overloading the method, change parameter variable type, if methods have same name
        public static void Showmessage(int TF)
        {
            System.Windows.Forms.MessageBox.Show(TF.ToString());
        }

        // L22 add another variable to the parameters, to avoid overloading method error
        public static void Showmessage(bool TF, bool myTF)
        {
            System.Windows.Forms.MessageBox.Show(TF.ToString());
        }
    }
}
