using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer ("John", 1 );
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            var order = new Order();
            Customer.Order.Add(order);


        }
    }
}
