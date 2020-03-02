// <Summary>
// Задачи на семинар
// Простые алгоритмы
// Эти задачи можно использовать для самостоятельного решения или для решения на семинарах.Пожалуйста,
// не публикуйте решения задач в комментариях.
//
// Expr1.Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной.
// Стоит ли так делать?
// Expr2.Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е.получить 
// трехзначное число, записанное теми же цифрами в обратном порядке.
// Expr3.Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками.Например, 
// 5 часов -> 150 градусов, 20 часов -> 120 градусов.Не использовать циклы.
// Expr4.Найти количество чисел меньших N, которые имеют простые делители X или Y.
// Expr5.Найти количество високосных лет на отрезке [a, b] не используя циклы.
// Expr6.Посчитать расстояние от точки до прямой, заданной двумя разными точками.
// Expr7.Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.
// Expr8.Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A. 
// Можете считать, что прямая задана либо двумя точками, либо коэффициентами уравнения прямой — как вам удобнее.
//
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson1
{
    public class Seminar1
    {
        // <Summary>
        // Как поменять местами значения двух переменных? 
        // Можно ли это сделать без ещё одной временной переменной.Стоит ли так делать?
        // </Summary>
        public static void Swap(object obj1, object obj2)
        {
            Console.WriteLine(obj1.ToString() + " " + obj2.ToString());
            object tmp = obj1;
            obj1 = obj2;
            obj2 = tmp;
            Console.WriteLine(obj1.ToString() + " " + obj2.ToString());
        }
        // <Summary>
        // Задается натуральное трехзначное число (гарантируется, что трехзначное). 
        // Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
        // </Summary>
        public static void Reverse(uint num)
        {
            Console.WriteLine(num);
            string reverse = "";
            foreach (char c in num.ToString())
                reverse = c + reverse;
            Console.WriteLine(reverse);
        }
        // <Summary>
        // Задано время Н часов(ровно). Вычислить угол в градусах между часовой и минутной стрелками.
        // Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов.Не использовать циклы.
        // </Summary>
        public static void HourArrowToAngle(uint hour)
        {
            Console.WriteLine(hour);
            Console.WriteLine((hour * 30) % 360);
        }
        // <Summary>
        // Найти количество чисел меньших N, которые имеют простые делители X или Y.
        // </Summary>
        public static int SimpleDivisors(uint N, uint X, uint Y)
        {
            if (!IsPrime(X) || !IsPrime(Y))
                return -1;

            int counter = 0;

            for (uint i = 1; i <= N; i++)
                if ((i % X == 0) || (i % Y == 0))
                    counter++;

            return counter;

            bool IsPrime(uint number)
            {
                if (number == 1) return false;
                if (number == 2) return true;

                var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

                for (int i = 2; i <= limit; ++i)
                    if (number % i == 0) return false;

                return true;
            }
        }
        // <Summary>
        //  Найти количество високосных лет на отрезке[a, b] не используя циклы.
        // </Summary>
        public static int LeapYearCounter(DateTime date1, DateTime date2, bool useCycle)
        {
            int count = 0;
            if (date2 < date1) return -1;
            if (useCycle)
            {
                for (int year = date1.Year; year <= date2.Year; year++)
                    if (year % 4 == 0) count++;

                return count;
            }
            else
            {
                count = date2.Year / 4 - date1.Year / 4;
                if (date1.Year % 4 == 0) count++;

                return count;
            }
        }
        // <Summary>
        // Посчитать расстояние от точки до прямой, заданной двумя разными точками.
        // </Summary>
        public static double PointToLineDistance(Point2D A, Point2D P1, Point2D P2)
        {
            return Math.Abs(A.X*(P2.Y-P1.Y) - A.Y*(P2.X-P1.X) + P2.X*P1.Y - P2.Y*P1.X) / 
                Math.Sqrt(Math.Pow(P2.Y-P1.Y,2) + Math.Pow(P2.X - P1.X, 2));
        }
        // <Summary>
        // Вспомогательный класс
        // </Summary>
        public class Point2D
        {
            private double x;
            private double y;
            public double X
            {
                get { return x; }
                set
                {
                    if (!Double.IsFinite(value))
                        throw new ArgumentException();
                    x = value;
                }
            }
            public double Y
            {
                get { return y; }
                set
                {
                    if (!Double.IsFinite(value))
                        throw new ArgumentException();
                    y = value;
                }
            }
            public Point2D(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
