using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays in C# has a fixed size
            // Arrays Data struct used to store a collection of the same type
            int[] numbers = new int[10];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 75;
            numbers[3] = 74;
            numbers[4] = 95;
            numbers[5] = 27;
            numbers[6] = 14;
            numbers[7] = 82;
            numbers[8] = 781;
            numbers[9] = 224;
            
            // or 
            int[] numbers2 = new int[12] { 2, 3, 45, 23, 57, 43, 24, 68, 7,89, 3,4 };
            Console.WriteLine(numbers2[7]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[8]);
            Console.WriteLine(numbers[6]);

            var flags = new bool[5];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[5] {"Edward", "Nana Yaw", "Nii Dodu","Ama" ,"Adwoa"};
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
            Console.WriteLine(names[1]);


        }
    }
}
