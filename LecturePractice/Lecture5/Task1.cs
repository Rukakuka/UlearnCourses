// <Summary>
// Четный массив
// Напишите метод, который создает массив длинной count элементов, 
// содержащий последовательные четные числа в порядке возрастания.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
    public class Task1
    {
		public static int[] GetFirstEvenNumbers(int count)
		{
			var s = new int[count];
			for (int i = 0; i < count; i++)
				s[i] = (i + 1) * 2;
			return s;
		}
	}
}
