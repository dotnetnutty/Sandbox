using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public static class ExtensionMethods
    {
        public static string PrefixWithHello(this string input)
        {
            return "Hello! " + input;
        }
    }
}
