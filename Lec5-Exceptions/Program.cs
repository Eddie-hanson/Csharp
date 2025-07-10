using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5_Exceptions
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int repeat = 0;
            int response = 1;
           
                while (response == 1)
                {
                try
                {
                    Console.WriteLine($"Hello {repeat}");
                    Console.WriteLine("repeat ? 1:Yes, 2:No");
                    response = Convert.ToInt32(Console.ReadLine());
                   
                }
            catch (FormatException ex)
            {
                Console.WriteLine($"*************Exception Occurred ***************\n ");
            }
                catch (Exception) 
                {
                    Console.WriteLine("General Exception Occured");
                }
            finally
                {
                    repeat++;
                }
        }

           
        }
    }
}
