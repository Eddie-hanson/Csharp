using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var name = "Edward Hanson";
            //for (var i = 0; i< name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            //foreach (var character in name){
            //    Console.WriteLine(character);
            //}
            //var numbers= new int[] { 1, 2, 3, 4, 5 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            var i = 0;
            while ( i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                                  
                }
                i++;

            }
            while (true)
            {
                Console.Write("Write your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                { Console.WriteLine("Echo :" + input);
                    continue;
                }
                break;

               

            }


        }
    }
}
