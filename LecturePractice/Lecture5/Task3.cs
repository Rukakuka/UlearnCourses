// <Summary>
// Подсчет 
// Тренировки продолжаются. На этот раз вы с Васей наперегонки 
// решаете одну задачу — найти количество вхождений заданного числа в массив чисел.
// Например, в массиве 1, 2, 1, 1 число 1 встречается 3 раза.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
    public static class Task3
    {
        public static int GetElementCount(int[] items, int itemToCount)
        {
            int counter = 0;
            foreach (var item in items)
            {
                if (item == itemToCount)
                    counter++;
            }
            return counter;
        }
    }
}
