using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;   // C# 6.0

namespace ConsoleApplication
{
    class Program
    {
        //C# 6.0 getter-only property and property initialiser
        public static string FirstName { get; } = "Neil";
        public static string LastName { get; } = "Pullinger";

        static void Main(string[] args)
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(Sqrt(9));

            string fullName = GetFullName();
            Console.WriteLine($"Full name: {fullName}"); // C# 6.0 string format

            // C# 6.0 index initialisers
            var myDict = new Dictionary<int, string>
            {
                [1] = "Item 1",
                [2] = "Item 2",
                [3] = "Item 3"
            };

            // C# 6.0 null conditional operator "?" and "?." (latter is "Elvis" operator)
            if (myDict?[2]?.GetType() == typeof(string))
            {
                Console.WriteLine("myDict is not null. myDict[2] is not null. myDict[2] is a string.");
            }

            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }

            var array = new[] { 1, 2, 3 };
            var list = new List<int>(array) { [1] = 5 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // C# 6.0 method expression
        static string GetFullName() => $"{FirstName} {LastName}";

        static void Check(string input)
        {
            if (input == null)
            {
                // C# 6.0 nameof() means if method parameter is renamed, below line is updated
                throw new ArgumentNullException(nameof(input));
                //throw new ArgumentNullException("input");
            }
        }

        /* Also, instead of:

        var onChanged = OnChanged;

        if( onChanged != null ){
            onChanged( this, args );
        }

        Can now use:

        OnChanged?.Invoke(this, args);
    */
    }
}
