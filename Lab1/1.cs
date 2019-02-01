using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = int.Parse(Console.ReadLine()); // первый элемент считал и перевел в int
			string s = Console.ReadLine(); 
			string[] a = s.Split(); // поделил строки через пробел и залил в массив
			int cnt1 = 0; // нужно что бы посчитать сколько у нас prime
			List<int> c = new List<int>(); // создал List для prime числов
			for(int i=0; i<x; i++)
			{
				int b = int.Parse(a[i]); // каждый элемент в массиве перевел в int
				int cnt = 0; // нужно что бы посчитать сколько делителей у числа
				for(int j=1; j<=b; j++)
				{
					if (b % j == 0) //если есть делитель то ++
					{
						cnt++;
					}
				}
				if (cnt == 2) // делитель равен 2 означает что это число prime
				{
					cnt1++;
					c.Add(b);
				}
			}
			Console.WriteLine(cnt1); // нам нужно вывести сколько у нас prime
			for(int i=0; i<c.Count; i++)
			{
				Console.Write(c[i] + " "); // и каждый prime
			}
		}
	}
}
