using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._19
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 1;
			Console.WriteLine("please enter a number similar to the random number");
			int a = Convert.ToInt32(Console.ReadLine());
			Random engine = new Random();
			int secretNumber = engine.Next(100) + 1;
			while (a != secretNumber)
			{
				counter++;
				if (a > secretNumber)
				{
					Console.WriteLine($"{a} is bigger");
				}
				if (a < secretNumber)
				{
					Console.WriteLine($"{a} is smaller");
				}
				a = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine($"{a} is the right number ");
			Console.WriteLine($"{counter} times took you to guess the right number");
		}
	}
}
