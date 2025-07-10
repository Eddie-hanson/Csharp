using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
        internal class Program
    {
        static void Main(string[] args)
        {
            var season =    Season.autumn;
            switch (season) 
            {
                case Season.autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;
                case Season.spring:
                    Console.WriteLine("It's spring don't forget to get an umbrella");
                    break;
                case Season.summer:
                    Console.WriteLine("It's summer let's go to the beach");
                    break;
                case Season.winter:
                    Console.WriteLine("It's Winter, remember to keep a winter jacket");
                    break;
                default:
                    Console.WriteLine("I don't understand the season");
                    break;  




            }
        }
    }
}
