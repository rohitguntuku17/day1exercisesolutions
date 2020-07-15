using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_dayclass_1_problem
{
	class Program
	{
		static void Main(string[] args)
		{
			int centigrades;
			float fharenhrit;

			Console.Write("enter centigrades :");
			centigrades = Convert.ToInt32(Console.ReadLine());

			fharenhrit = (centigrades * 9 / 5) + 32;
			Console.Write(" temperature in fharenhrit is : " + fharenhrit);
			Console.ReadLine();

		}
	}
}
