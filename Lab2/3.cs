using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp7
{
	class Program
	{
		public static void Probels(int x) // создал функцию что бы создавать пробелы
		{
			for(int i=0; i<x; i++) // проходя по циклу я создаю определенное количество пробелов
			{
				Console.Write("     ");
			}
		}
		public static void Folders(DirectoryInfo dir, int x)
		{ 
			foreach(FileInfo files in dir.GetFiles()) // пробегаемся по всем файлам в указанной Directory 
			{
				Probels(x); // вызываем функцию пробелов
				Console.WriteLine(files.Name); // и выводим имя файла
			}
			foreach(DirectoryInfo d in dir.GetDirectories()) // пробегаемся по всем папкам в указанной Directory
			{
				Probels(x); // вызываем функцию пробелов
				Console.WriteLine(d.Name); // выводим имя папки
				Folders(d, x + 1); // и обратно рекурсивно обращаемся к этой папке
			}
		}
		static void Main(string[] args)
		{
			DirectoryInfo d = new DirectoryInfo("/Users/User/Desktop/Damn/C++"); // путь файла 

			Folders(d,0); // вызываем функцию..рекурсию
		}
	}
}
