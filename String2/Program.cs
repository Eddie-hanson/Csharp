using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Edwards";
            var lastName = " Hammed";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {1} {0}", firstName, lastName);
            var names = new string[3] { "Eddie", "Edna", "Ama" };
            var formatName = string.Join(",", names);
            var text =@"John 
Look into the following path 
C:\Users\Mr Hanson\Desktop\programming_2 ";

            Console.WriteLine(myFullName);
            Console.WriteLine(fullName);
            Console.WriteLine(formatName);
            Console.WriteLine(text);








        }
    }
}
