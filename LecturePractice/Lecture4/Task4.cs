// <Summary>
// Стали известны подробности про новую игру Васи. Оказывается ее действия разворачиваются на шахматных досках нестандартного размера.
// У Васи уже написан код, генерирующий стандартную шахматную доску размера 8х8.
// Помогите Васе переделать этот код так, чтобы он умел выводить доску любого заданного размера.
// Белая клетка обозначается точкой, черная — шарпом.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture4
{
    public static class Task4
    {
		
		public static void ChessBoard()
		{
			WriteBoard(8);
			WriteBoard(1);
			WriteBoard(2);
			WriteBoard(3);
			WriteBoard(10);
		}
		private static void WriteBoard(int size)
		{
			bool even = true;
			for (int line = 0; line < size; line++)
			{
				for (int col = 0; col < size; col++)
				{
					Console.Write(even ? "#" : ".");
					even = !even;
				}
				if (size % 2 ==0 )
					even = !even;
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
