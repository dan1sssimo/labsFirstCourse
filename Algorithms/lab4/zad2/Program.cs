using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishCount
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			while (true)
			{
				Console.Write("Введіть вираз: ");
				Console.WriteLine(ReversePolishCount.Calculate(Console.ReadLine()));
			}
		}
	}
}