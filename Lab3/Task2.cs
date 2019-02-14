using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
	class FarManager
	{
		int cursor;
		int cnt;
		public FarManager()
		{
			cursor = 0;
		}
		public void Show(DirectoryInfo dire, int z)
		{
			FileSystemInfo[] d = dire.GetFileSystemInfos();
			for (int i = 0; i < d.Length; i++)
			{
				if (z == i)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Red;
					Console.WriteLine(i + 1 + ". " + d[i].Name);
				}
				else if (d[i].GetType() == typeof(FileInfo))
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.WriteLine(i + 1 + ". " + d[i].Name);
				}
				else if (d[i].GetType() == typeof(DirectoryInfo))
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.WriteLine(i + 1 + ". " + d[i].Name);
				}
			}
		}
		public void Up()
		{
			cursor--;
			if (cursor < 0)
			{
				cursor = cnt - 1;
			}
		}
		public void Down()
		{
			cursor++;
			if (cursor == cnt)
			{
				cursor = 0;
			}
		}
		public void Start(string path)
		{
			ConsoleKeyInfo button = Console.ReadKey();
			while (button.Key != ConsoleKey.Escape)
			{
				DirectoryInfo dir = new DirectoryInfo(path);
				FileSystemInfo[] d = dir.GetFileSystemInfos();
				cnt = d.Length;
				Show(dir, cursor);
				button = Console.ReadKey();
				Console.BackgroundColor = ConsoleColor.Black;
				Console.Clear();
				if (button.Key == ConsoleKey.F2) //F2 нужна что бы переименовать имя 
				{
					if (d[cursor].GetType() == typeof(FileInfo))//переименовать имя файла
					{
						string s = Console.ReadLine();//вводим имя
						string s1 = Path.Combine(dir.FullName, s); // комбинируем это имя с путем
						File.Move(d[cursor].FullName, s1); // переименуем
						Console.BackgroundColor = ConsoleColor.Black; //нужно для того что бы мы сразу видели изменения
						Console.Clear();
					}
					if (d[cursor].GetType() == typeof(DirectoryInfo))//для папки
					{
						string s = Console.ReadLine();
						string s1 = Path.Combine(dir.FullName, s);
						Directory.Move(d[cursor].FullName, s1);
						Console.BackgroundColor = ConsoleColor.Black;
						Console.Clear();
					}
				}
				if (button.Key == ConsoleKey.Delete) //кнопка del что бы удалить
				{
					if (d[cursor].GetType() == typeof(FileInfo))//удаление файла
					{
						File.Delete(d[cursor].FullName);
					}
					if (d[cursor].GetType() == typeof(DirectoryInfo)) // для папки
					{
						DirectoryInfo ddd = new DirectoryInfo(d[cursor].FullName);
						FileSystemInfo[] dd = ddd.GetFileSystemInfos(); // проверяем есть ли внутри этой папки есть какие нибудь файлы
						if (dd.Length == 0) // если нет то удаляем данную папку
						{
							Directory.Delete(d[cursor].FullName);
						}
						else
						{
							Console.WriteLine("This folder not empty, so it can't be deleted"); // иначе говорим что эта папка не пуста
						}

					}
				}
				if (button.Key == ConsoleKey.UpArrow)
				{
					Up();
				}
				if (button.Key == ConsoleKey.DownArrow)
				{
					Down();
				}
				if (button.Key == ConsoleKey.Enter)
				{
					if (d[cursor].GetType() == typeof(FileInfo)) // для того что бы открыть текстовые файлы
					{
						StreamReader sr = File.OpenText(d[cursor].FullName);
						string s = sr.ReadToEnd(); // сохраняем все что есть в текстовом файле в строку
						sr.Close();//закрываем
						Console.WriteLine(s);// и выводим на экран
					}
					if (d[cursor].GetType() == typeof(DirectoryInfo))
					{
						path = d[cursor].FullName;
						cursor = 0;
					}
				}
				if (button.Key == ConsoleKey.Backspace)
				{
					cursor = 0;
					dir = dir.Parent;
					path = dir.FullName;
				}
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			FarManager far = new FarManager();
			far.Start(@"C:\Users\User\Desktop\Damn\C#");
		}
	}
}