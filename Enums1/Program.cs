using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums1

{
    public enum shippingMethod
    {
        RegularMail = 1,
        RegisteredMail =2,
        Express = 3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enums
            // A set of name/value pairs 
            var method = shippingMethod.Express;
            Console.WriteLine((int)method);
            var methodID = 3;
            // casting = Console.WriteLine((shippingMethod)methodID);
            Console.WriteLine((shippingMethod)methodID);

        }
    }
}
