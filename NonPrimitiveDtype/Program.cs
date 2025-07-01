using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NonPrimitiveDtype.Math;

namespace NonPrimitiveDtype
{
    public class Person 
    {
        public string firstName;
        public string lastName;
        public void introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var person = new Person();
                person.firstName = "EDWARD";
                person.lastName = "HANSON";
                person.introduce();
                Calculator calculator = new Calculator();
                var result=calculator.Add(4, 8);
                Console.WriteLine(result);
            }
        }
    }

}