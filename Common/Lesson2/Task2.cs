// <Summary>
// Минимум функции
// Эта задача потребует знания конструкции if-else. Если вы с ней знакомы из других языков программирования, это не составит проблем.
// Если не знакомы совсем, то лучше пропустить эту задачу и сначала пройти следующий модуль.
// Реализуйте метод GetMinX для нахождения такого числа X, при котором кривая, заданная уравнением 
// y(x) = ax ^ 2 + bx + cy(x), принимает минимальное значение.
// Метод должен принимать неотрицательный коэффициент A, а также произвольные коэффициенты B и C, и, 
// если решение существует, возвращать строковое представление искомого X, а иначе — строку Impossible.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lesson2
{
    public class Task2
    {
        public static void MinValue()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        //
        // Summary:
        //     Represents a double-precision floating-point number.
        public static string GetMinX(double a, double b, double c)
        {
            if (a <= 0)
                if (b != 0)
                    return "Impossible";

            return (-b / (2 * a)).ToString();
        }
    }
}
