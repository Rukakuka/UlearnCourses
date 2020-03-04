// <Summary>
// Области видимости - тест
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture1
{
	public class Test1
	{
		static string who = "class";

		public static void Mixed()
		{
			//Console.Write(who + " ");
			string who = "Mixed";
			Console.Write(who);
		}
		public static void M1()
		{
			int i = 0;
			{
				//int i = 1;
			}
		}
		public static void M2(int i)
		{
			//int i = 0;
		}
	}
}
