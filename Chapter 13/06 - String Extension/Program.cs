using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___String_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Clones are wreaking havoc at the factory. Help!";
            message.IsDestressCall();
        }
    }
}
namespace MyExtensions
{
    public static class HumanExtensions
    {
        public static bool IsDestressCall(this string s)
        {
            if (s.Contains("Help!"))
                return true;
            else
                return false;
        }
    }
}
