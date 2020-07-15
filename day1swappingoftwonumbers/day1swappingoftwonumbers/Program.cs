using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1swappingoftwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
