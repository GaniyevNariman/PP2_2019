using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader sr = File.OpenText(@"C:\Users\User\Desktop\Damn\C#\MYY.txt");
			string s = "";
			while ((s = sr.ReadLine()) != null)
			{
				Console.WriteLine(s);
			}
		}
	}
}
