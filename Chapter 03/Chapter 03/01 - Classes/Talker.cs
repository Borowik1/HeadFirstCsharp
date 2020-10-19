using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Classes
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTines)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTines; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
