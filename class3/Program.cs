using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        static void calc()
        {
            var num = new Calculator.Add(1, 2, 3, 4);
            Console.WriteLine(num);

        }
        static void usePoint()
        {
            try
            {
                var point = new Point(10, 40);
                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("point is at ({0},{1})", point.X, point.Y);
                point.Move(100, 530);
                Console.WriteLine("point is at ({0},{1})", point.X, point.Y);


            }
            catch (Exception)
            {

                Console.WriteLine("An exception error occured ");
            }


        }
    }
    }
}
