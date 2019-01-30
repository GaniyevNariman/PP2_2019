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
			int x = int.Parse(Console.ReadLine());
			for(int i=0; i<x; i++)
			{
				for(int j=0; j<=i; j++)
				{
					Console.Write("[*]");
				}
				Console.WriteLine();
			}
		}
	}
}
