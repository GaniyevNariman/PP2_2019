using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Student
	{
		public string Name { //создаем имя, айди и год обучения студента
			get; set;
		}
		public string Id {
			get; set;
		}
		public int Year {
			get; set;
		}
		
		public Student(string Name, string Id) //создаем конструктор, передающий имя и айди студента
		{
			this.Name = Name;
			this.Id = Id;
		}
		
		public void IncrementYear() //создаем конструктор для увеличения года обучения
		{
			Year++;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{	
			Student st = new Student("Nariman", "18BD11000") //даем значения  - имя и айди, год
			{
				Year = 1
			};
			Console.WriteLine("Name of student: " + st.Name + " ID: " + st.Id + " Course: " + st.Year); // выводим все данные
			st.IncrementYear(); //вызываем функцию, увеличивающую год обучения
			Console.WriteLine("Name of student: " + st.Name + " ID: " + st.Id + " Course: " + st.Year);// выводим данные с увеличенным годом обучения
		}
	}
}