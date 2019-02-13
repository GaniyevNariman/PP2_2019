using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] a = (Console.ReadLine()).Split(); // переводим в int первую строку
			string[] b = new string[n * 2]; // создаем новый массив в которым будут храниться числа с дубликатами
			for(int i=0; i<n; i++) // пробегаемся по циклу
			{
				b[i*2] = a[i]; // и делаем дубликаты
				b[i*2 + 1] = a[i];
			}

			for(int i=0; i<n*2; i++) // выводим числа
			{
				Console.Write(b[i] + " ");
			}
		}
	}
}
