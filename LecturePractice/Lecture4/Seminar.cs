// <Summary>
// Задачи на семинар
// Эти задачи можно использовать для самостоятельного решения или для решения на семинарах. Пожалуйста,
// не публикуйте решения задач в комментариях.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LecturePractice.Lecture4
{
    public static class Seminar
    {
        // <Summary>
        // Loops1. Дано целое неотрицательное число N. Найти число, 
        // составленное теми же десятичными цифрами, что и N, но в обратном порядке. 
        // Запрещено использовать массивы.
        // </Summary>
        public static void InvertNumber(int number)
        {
            string straight = number.ToString();
            string reversed = "";
            for (int i = straight.Length -1; i >= 0; i--)
                reversed += straight[i];
            Console.WriteLine(reversed);
        }
        // <Summary>
        // Loops2. Дано N(1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, 
        // сумма цифр которых равна N. Операции деления(/, %) не использовать.
        // </Summary>
        public static void ThreeSum(int number)
        {
            int counter = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (GetSum(i) == number)
                    counter++;
            }
            Console.WriteLine(counter);

            static int GetSum(int value)
            {
                var hunderets = value / 100;
                var decimals = (value % 100) / 10;
                var ones = value % 10;
                return ones + decimals + hunderets;
            }
        }
    }
}
