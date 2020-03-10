// <Summary>
// Индекс максимума
// Чтобы освоиться с массивами, вы с Васей решили потренироваться на простых алгоритмах.
// Вася написал метод поиска минимума в массиве: Min
// А вам выпала задача посложнее — написать метод поиска индекса максимального элемента.
// То есть такого числа i, что array[i] — это максимальное из чисел в массиве.
// Если в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.
// Если массив пуст, вывести нужно -1.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
	public class Task2
	{
        static double Min(double[] array)
        {
            var min = double.MaxValue;
            foreach (var item in array)
                if (item < min) min = item;
            return min;
        }
        static double MaxIndex(double[] array)
        {
            var index = -1;
            double maxValue = Int32.MinValue;
            if (array == null)
                return index;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    index = i;
                    maxValue = array[i];
                }
            }
            return index;
        }
    }
}
