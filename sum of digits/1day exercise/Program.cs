using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1day_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num, r;
            Console.WriteLine("enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("sum of digits of the number: " + sum);
            Console.ReadLine();
        }
    }
}
