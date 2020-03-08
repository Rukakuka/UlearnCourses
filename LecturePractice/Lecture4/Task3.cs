// <Summary>
// Вы решили помочь Васе с разработкой его игры и взяли на себя красивый вывод сообщений в игре.
// Напишите функцию, которая принимает на вход строку текста и печатает ее на экран в рамочке из символов +, - и |. 
// Для красоты текст должен отделяться от рамки слева и справа пробелом.
// Например, текст Hello world должен выводиться так:
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture4
{
    public class Task3
    {
		public static void TextWithBorder()
		{
			WriteTextWithBorder("Menu:");
			WriteTextWithBorder("");
			WriteTextWithBorder(" ");
			WriteTextWithBorder("Game Over!");
			WriteTextWithBorder("Select level:");
		}

		public static void WriteTextWithBorder(String str)
		{
			string border = "+";
			string midString = "| " + str + " |"; 

			for (int i = 0; i < str.Length + 2; i++)
				border += "-";
			border += "+";
			Console.WriteLine(border);
			Console.WriteLine(midString);
			Console.WriteLine(border);
		}
	}
}
