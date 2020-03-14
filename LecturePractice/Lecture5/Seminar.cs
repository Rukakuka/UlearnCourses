// <Summary>
// Задачи на семинар
// Эти задачи можно использовать для самостоятельного решения или для решения на семинарах. Пожалуйста,
// не публикуйте решения задач в комментариях.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LecturePractice.Lecture5
{
    public static class Seminar
    {
        // <Summary>
        // Arr1. Дан массив чисел. Нужно его сдвинуть циклически на K позиций вправо, не используя других массивов.
        // </Summary>
        public static object[] ShiftRight(object[] arr, int shift)
        {
           object tmp;
           for (int i = 0; i < shift; i++)
           {
                tmp = arr[arr.Length - 1]; // last item
                for (int j = arr.Length - 1; j > 0; j--)
                    arr[j] = arr[j - 1];
                arr[0] = tmp;
           }
            return arr;
        }
        // <Summary>
        // Arr2. Перевести число из системы счисления с основанием A в систему с основанием B. 
        // Можно считать, что 2 ≤ A, B ≤ 10, а число дано в виде массива цифр.
        // </Summary>
        public static void ChangeNumberBase(int[] value, int oldBase, int newBase)
        {
            string str = "";
            int num = 0;
            // int[] value to int intValue
            int j = value.Length - 1;
            for (int i = 0; i < value.Length; i++, j--)
                num += value[i] * (int)Math.Pow(oldBase, j);
            // to new base
            do {
                str = num % newBase + str;
                num /= newBase;
            } while (num != 0);
            Console.WriteLine(str);
        }
        // <Summary>
        // Arr3. Превратить рациональную дробь a/b (0 < a < b < 100000) в десятичную. 
        // Возможен период. "1/6" должна превратиться в "0.1(6)"
        // </Summary>
        public static void RationalToDecimal(int numerator, int denominator)
        {
            Console.WriteLine((double)numerator / denominator);
        }
    }
}
