using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)	
		{
			int x = int.Parse(Console.ReadLine()); // первый элемент считал и перевел в int
			for (int i=0; i<x; i++) // создал двойной цикл
			{
				for(int j=0; j<=i; j++) // здесь пробигаемся только до i для того что бы в строке было только i звездочек
				{
					Console.Write("[*]"); // выводит звездочки без endl
				}
				Console.WriteLine(); // endl для того что бы после каждой строки звездочки опускались вниз
			}
		}
	}
}
