using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int hour = 10;
            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("Morning");
            //}

            //else if (hour >= 12 && hour < 18)
            //    {
            //    Console.WriteLine("Afternoon");
            //}

            //else
            //    {
            //    Console.WriteLine("Evening");
            //}

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            bool isSilverCustomer = false;
            float Price = (isSilverCustomer) ? 109.95f : 525.95f;
            Console.WriteLine(price);
            Console.WriteLine(Price);
        }
    }
}
