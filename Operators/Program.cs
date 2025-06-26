using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators In C#
            var A = 10;
            var B= 20;
            var C = 30;
            Console.WriteLine("ADDITION" + " " + A +B);
            Console.WriteLine("SUBTRACTION " + A - B);
            Console.WriteLine( (float)A / (float)B);
            Console.WriteLine("MULTIPLICATION"+ " "+A * B);
            Console.WriteLine(A % B); 
            Console.WriteLine((A + B) * C);
            Console.WriteLine( A < B);
            Console.WriteLine(A > C);
            Console.WriteLine(A != B);
            Console.WriteLine(A == C);
            Console.WriteLine(!(A != B));
            Console.WriteLine(A >B && C>A);
            Console.WriteLine(A > B || C > A);
            Console.WriteLine(!(A > B || C > A));
        }
    }
}
