using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1largestofthreenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("input the 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the 3rd number:");
            num3 = convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("the 1st number is greatest amoung three\n");

                }
                else
                {
                    Console.Write("the 3rd number is greatest amoung three \n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd number is the greatest amoung three");
            else
                Console.Write("the 3rd number is greatest amoung three\n");

        }
    }
    }
}
