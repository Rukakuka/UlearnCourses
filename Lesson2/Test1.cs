// <Summary>
// Ошибки компиляции - тест
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson2
{
	
	class Program
	{
		static void Main()
		{
			System.Console.WriteLine(Min(4, 2, 3));
		}

		static int Min(int a, int b, int c)
		{
			return Math.Min(a, Math.Min(b, c));
		}
	}
}
