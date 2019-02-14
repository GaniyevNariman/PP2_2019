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
				if (button.Key == ConsoleKey.F2)
				{
					if (d[cursor].GetType() == typeof(FileInfo))
					{
						string s = Console.ReadLine();
						string s1 = Path.Combine(dir.FullName, s);
						File.Move(d[cursor].FullName, s1);
						Console.BackgroundColor = ConsoleColor.Black;
						Console.Clear();
					}
					if(d[cursor].GetType() == typeof(DirectoryInfo))
					{
						string s = Console.ReadLine();
						string s1 = Path.Combine(dir.FullName, s);
						Directory.Move(d[cursor].FullName, s1);
						Console.BackgroundColor = ConsoleColor.Black;
						Console.Clear();
					}
				}
				if(button.Key == ConsoleKey.Delete)
				{
					if (d[cursor].GetType() == typeof(FileInfo))
					{
						File.Delete(d[cursor].FullName);
					}
					if (d[cursor].GetType() == typeof(DirectoryInfo))
					{
						DirectoryInfo ddd = new DirectoryInfo(d[cursor].FullName);
						FileSystemInfo[] dd = ddd.GetFileSystemInfos();
						if(dd.Length == 0)
						{
							Directory.Delete(d[cursor].FullName);
						}
						else
						{
							Console.WriteLine("This folder not empty, so it can't be deleted");
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
					if (d[cursor].GetType() == typeof(FileInfo))
					{
						StreamReader sr = File.OpenText(d[cursor].FullName);
						string s = sr.ReadToEnd();
						sr.Close();
						Console.WriteLine(s);
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