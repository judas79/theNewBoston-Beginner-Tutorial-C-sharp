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
    // L28 struct, name, braces
    struct Client : IClient
    {
        // add a constructor c t o r TAB, set varibles to something if they exist below the constroctor
        // have at least 1 parameter in constroctor
        public Client(string name)
        {
            // Name equals parameter name as a value
            Name = name;
            Age = 0;

        }
        // public variables for holding the values of clients
        // name and age inside of the struct
        public string Name;
        public int Age;

        // method to clear clients information
        public void clearClientInfo()
        {
            Name = "";
            Age = 0;
        }
    }
    interface IClient
    {
        // public string Color;
    }
    // L19 sub namespace
    namespace mySubnamespace
    {
    }
    class myClass
    {
        // L27 string access modifier,
        public string this[int index]
            {
            // return the index passed through stringArray and 
            // index what is passed through the [index] parameter
            get { return stringArray[index]; }

            // index number value determines which stringArray item is selected
            set { stringArray[index] = value; }
            }
        // L27 indexers, string array 3 items
        string[] stringArray = {"Bob", "Carol", "Alice"};

    }
}

