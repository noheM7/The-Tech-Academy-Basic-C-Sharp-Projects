﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Put in # to multiply by 32:");
            int input = Convert.ToInt32(Console.ReadLine());

            
                int result = Multiplication.multiply(input);
              
                Console.WriteLine(result);
            
           






        }
    }
}