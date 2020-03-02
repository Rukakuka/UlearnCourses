﻿// <Summary>
// Неверный тип данных
// Неправильно указанный тип данных - 
// частая ошибка в работе начинающего программиста.Вот и сейчас программист Вася в замешательстве.
// Исправьте положение — укажите у всех объявленных переменных правильные типы вместо многоточия.
// Не используйте ключевое слово var при решении этой задачи.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson1
{
    public class Task2
    {
        public static void Print()
        {
            double num1 = +5.5e-2;
            float num2 = 7.8f;
            int num3 = 0;
            long num4 = 2000000000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
    }
}
