using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine( b +" " + a);
            Console.WriteLine(string.Format("a: {0} b: {1} ", a , b));
            var arr = new int[5] { 1, 2,3,4,5};
            var arr2 = arr;
            arr2[0] = 4;
            Console.WriteLine(string.Format("arr: {0} arr2: {1} ", arr[0], arr2[0]));

        }
    }
}
