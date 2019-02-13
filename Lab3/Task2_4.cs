using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_2_4
{
	class Program
	{
		static void Main(string[] args)
		{
			File.Move(@"C: \Users\User\Desktop\Damn\C#\MYY.txt", @"C:\Users\User\Desktop\Damn\C#\Newnew.txt"); // переименовывать файл
		}
	}
}
