// <Summary>
// В поисках степени двойки
// Найдите минимальную степень двойки, превосходящую заданное число.
// Более формально: для заданного числа nn найдите x > n, такой, что x = 2 ^ k 
// для некоторого натурального k
// Решите эту задачу с помощью цикла while.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture4
{
    public class Task1
    {
		public static void LookingForPowerOfTwo()
		{
			Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
			Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
			Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
			Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
			Console.WriteLine(GetMinPowerOfTwoLargerThan(100));

		}
		private static int GetMinPowerOfTwoLargerThan(int number)
		{
			int result = 1;
			while (result <= number) 
				result *= 2;
			return result;
		}
	}
}
