using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strings are a sequence of characters
            // The are surrounded with double quotes

            // String declaration 
            string firstName = "Edward";
            string lastName = "Degraft";
            // strings are concatenated using the + sign and a string literal " "
            string name = firstName + " " + lastName;
            // or the format method....."{0} {1}" are know the placeholders, they represent how strings will be represented 
            string name1 = string.Format("{0} {1}", firstName, lastName);
            // Combining elements of and array using a seperator
            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            string name2 = "Hannah";
            char firstChar = name2[0];
            Console.WriteLine(name2);
            Console.WriteLine(firstChar);
            // In C# strings are immutable
            // Verbatim string prefix a string with an @ to use a single backslash

        }
    }
}
