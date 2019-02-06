using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine(); // считал и сохранил это как строку s
			for (int i = 0; i < s.Length / 2; i++) // пробежался с циклом до половины
			{
				if (s[i] != s[s.Length - 1 - i]) // здесь проверяется зеркальные элементы
				{
					Console.WriteLine("NO"); // если хоть один не похож то это не полиндром так что выводим NO и завершаем программу
					return; 
				}
			}
			Console.WriteLine("YES"); // а если все прошло успешно то тогда выводим YES
		}
	}
}
