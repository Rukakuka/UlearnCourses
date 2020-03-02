// <Summary>
// Главный вопрос вселенной
// Многие знают, что ответ на главный вопрос жизни, вселенной и всего такого — 42.
// Но Вася хочет большего! Он желает знать квадрат этого числа!
// Вы разделили с Васей работу — он написал главный метод Main, а вам осталось лишь дописать методы Print и GetSquare.
// Создайте два метода Print и GetSquare, так, чтобы код снизу заработал.Если забыли синтаксис определения методов,
// подсмотрите в видеолекции или в предыдущие задачи.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson1
{
    public class Task8
    {
        public static void VasyaSquareRoot()
        {
            Print(GetSquare(42));
        }
        public static double GetSquare(double val)
        {
            return Math.Pow(val,2);
        }
        public static void Print(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
