using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classses1
{
    internal class Program
    {
        public class Person
        {
            public string Name;
            public void Introduce(string to ) 
            {
                Console.WriteLine("Hi {0}, my name is {1} ", to, Name);

            }
            public static Person Parse(string str) 
            {
                var person = new Person();
                person.Name = str;

                return person;
        }
            static void Main(string[] args)
            {
                // // Creating an instance of a class
                //// Instance 1
                // Person person = new Person();
                // person.Name = "Edward";
                // person.Introduce("Ama");
                //         //OR
                // // Instance 2
                // var person2 = new Person();
                // person2.Name = "De-graft";
                // person2.Introduce("Esi");
                // Creating an instance of a class
                // Instance 1

               
                var person2 = Person.Parse("Naana");
                person2.Introduce("Prof. Hanson");

            }   }
    }
}
