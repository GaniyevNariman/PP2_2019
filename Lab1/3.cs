using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = int.Parse(Console.ReadLine()); // первый элемент считал и перевел в int
			string s = Console.ReadLine();
			string[] a = s.Split(); // поделил строки через пробел и залил в массив

			Console.WriteLine();
			for (int i = 0; i < x; i++)
			{
				Console.Write(a[i] + " " + a[i] + " "); // вывел элемент дважды
			}
		}
	}
}
