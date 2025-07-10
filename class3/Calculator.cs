using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Calculator
    {
  
        
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                   
                }
            return sum;
        }
        }
    }



