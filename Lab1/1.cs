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
			int x = int.Parse(Console.ReadLine());
			string s = Console.ReadLine();
			string[] a = s.Split();
			int cnt1 = 0;
			List<int> c = new List<int>();
			for(int i=0; i<x; i++)
			{
				int b = int.Parse(a[i]);
				int cnt = 0;
				for(int j=1; j<=b; j++)
				{
					if (b % j == 0)
					{
						cnt++;
					}
				}
				if (cnt == 2)
				{
					cnt1++;
					c.Add(b);
				}
			}
			Console.WriteLine(cnt1);
			for(int i=0; i<c.Count; i++)
			{
				Console.Write(c[i] + " ");
			}
		}
	}
}
