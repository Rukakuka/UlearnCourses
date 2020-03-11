// <Summary>
// Null или не null
// Вася написал метод, проверяющий, что первый элемент переданного массива равен 0. 
// Вася даже проверил, что ему не передали в качестве массива null. Но что-то все равно не работает.
// Исправьте ошибку и разберитесь, почему код не работал.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
    class Task6
    {
        public static void ToNullOrNotToNull()
        {
            Console.WriteLine(CheckFirstElement(null));
            Console.WriteLine(CheckFirstElement(new int[0]));
            Console.WriteLine(CheckFirstElement(new[] { 1 }));
            Console.WriteLine(CheckFirstElement(new[] { 0 }));
        }
        public static bool CheckFirstElement(int[] array)
        {
            return array != null && array.Length != 0 && array[0] == 0;
        }
    }
}
