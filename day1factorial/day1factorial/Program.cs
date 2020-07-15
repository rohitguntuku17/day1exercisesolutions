﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Input any positive number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            long fact = FactorialCalcu(n1);
            Console.WriteLine(" The factorial of {0} is : {1} ", n1, fact);
            Console.ReadKey();
        }

        private static long FactorialCalcu(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactorialCalcu(n1 - 1);
        }
    }
}
