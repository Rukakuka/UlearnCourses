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
            for (int i = straight.Length - 1; i >= 0; i--)
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
        // <Summary>
        // Loops3. Если все числа натурального ряда записать подряд каждую цифру в своей позиции, 
        // то необходимо ответить на вопрос: какая цифра стоит в заданной позиции N.
        // </Summary>
        public static void NaturalRow(int number)
        {
            string row = "";
            for (int i = 1; i < number + 1; i++)
                row += i.ToString();
            Console.WriteLine(row[number - 1]);
        }
        // <Summary>
        // Loops4.В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
        // </Summary>
        public static void LongestCombo(int[] arr)
        {
            int combo, maxcombo;
            maxcombo = combo = 1;

            int index = -1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    combo++;
                    if (combo > maxcombo)
                    {
                        index = i;
                        maxcombo = combo;
                    }
                }
                else combo = 1;
            }
            if (index == -1)
            {
                Console.WriteLine("Not found");
                return;
            }
            for (int i = index - maxcombo + 1; i <= index; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // <Summary>
        // Loops5.Дана строка из символов '(' и ')'. 
        // Определить, является ли она корректным скобочным выражением.
        // Определить максимальную глубину вложенности скобок.
        // </Summary>
        public static void Brackets(string brackets)
        {
            if (String.IsNullOrEmpty(brackets) || brackets.Length % 2 != 0)
                throw new ArgumentException();
            int count = 0;
            int maxBracket = 0;
            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i].Equals('('))
                {
                    count++;
                    if (maxBracket < count)
                        maxBracket = count;
                }
                else
                    count = 0;
            }
            Console.WriteLine("Max deep = {0}", maxBracket);
        }
    }
}
