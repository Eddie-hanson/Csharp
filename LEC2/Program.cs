using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC2
{
    internal class Program
    {
        public class Person
        {
            public int Id { get; }
            public string Name { get; set; }

            public int AddTwoNumbers(int num1, int num2)
            {
                return num1 + num2;
            }

             


        }
        static void Main(string[] args) 
        {
            for (int i = 0; i < 8; i = i++) 
            {
                Console.WriteLine(i);
            }


        }
    }
}
