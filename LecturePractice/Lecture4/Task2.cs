// <Summary>
// Убрать пробелы 
// Враги вставили в начало каждого полезного текста целую кучу бесполезных пробельных символов!
// Вася смог справиться с ситуацией, когда такой пробел был один, но продвинуться дальше ему не удается.
// Помогите ему с помощью цикла while.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture4
{
	public class Task2
	{
		public static void RemoveSpaces()
		{
			Console.WriteLine(RemoveStartSpaces("a"));
			Console.WriteLine(RemoveStartSpaces(" b"));
			Console.WriteLine(RemoveStartSpaces(" cd"));
			Console.WriteLine(RemoveStartSpaces(" efg"));
			Console.WriteLine(RemoveStartSpaces(" text"));
			Console.WriteLine(RemoveStartSpaces(" two words"));
			Console.WriteLine(RemoveStartSpaces("  two spaces"));
			Console.WriteLine(RemoveStartSpaces("	tabs"));
			Console.WriteLine(RemoveStartSpaces("		two	tabs"));
			Console.WriteLine(RemoveStartSpaces("                             many spaces"));
			Console.WriteLine(RemoveStartSpaces("               "));
			Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
		}
		private static string RemoveStartSpaces(string text)
		{
			return text.Trim();
		}
	}
}
