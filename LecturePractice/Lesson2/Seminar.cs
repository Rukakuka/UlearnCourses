// <Summary>
// Задачи на семинар
// Эти задачи можно использовать для самостоятельного решения или для решения на семинарах. Пожалуйста,
// не публикуйте решения задач в комментариях.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lesson2
{
    public static class Seminar
    {
        // <Summary>
        // Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
        // </Summary>
        public static void NumberSum()
        {
            int bag = 0;
            for (int num = 1; num <= 1000; num++)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    bag += num;
                }
            }
            Console.WriteLine($"Sum = {bag}");
        }

        // <Summary>
        // Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
        // </Summary>
        public static void PrintHourMinuteAngle(int hour, int minute)
        {
            if (hour < 0 || hour > 24 || minute < 0 || minute > 60)
                throw new ArgumentException();

            double alpha = (hour * 30) % 360;
            double beta = (minute * 6) % 60;
            Console.WriteLine($"Angle is {alpha - beta}");
        }

        // <Summary>
        // Expr12. 1885. Комфорт пассажиров
        // Самолёт должен набрать высоту h метров в течение первых t секунд полёта и 
        // удерживать её в течение всего полёта.Разрешён набор высоты со скоростью не более 
        // чем v метров в секунду.До полного набора высоты запрещено снижаться.Известно, что уши
        // заложены в те и только те моменты времени, когда самолёт поднимается со скоростью
        // более x метров в секунду. Посчитайте минимальное и максимальное возможное время, 
        // в течение которого у пассажиров будут заложены уши. Считайте, что самолёт способен
        // изменять скорость мгновенно.
        // 
        // Исходные даныне:
        // целые числа h, t, v, x (5000 ≤ h ≤ 12000; 50 ≤ t ≤ 1200; 1 ≤ x < v ≤ 100; h ≤ t · v), где
        // h - высота полёта,
        // t - время подъема до h,
        // x - минимальная скорость подъема, начиная от которой закладывает уши
        // v - максимальная скорость подъема самолета
        // Пример: Ввод (10000, 500, 50, 10) -> Вывод (125 500)
        // </Summary>
        public static void PassengersComfort(double h, double t, double v, double x)
        {
            if (h < 5000 ||
                h > 12000 ||
                t < 50 ||
                t > 1200 ||
                x < 1 ||
                x > v ||
                v > 100 ||
                t * v < h)
                throw new ArgumentException();

            double tmin;
            double tmax;

            // 1)
            tmax = t;
            // 2)
            tmin = (h - x * t) / (v - x);

            Console.WriteLine(tmin + " " + tmax);
        }

        // <Summary>
        // Expr13. 1084. Пусти козла в огород
        // Козла пустили в квадратный огород и привязали к колышку.Колышек воткнули точно в центре огорода.
        // Козёл ест всё, до чего дотянется, не перелезая через забор огорода и не разрывая веревку.
        // Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.
        // </Summary>
        public static void GoatAndRope(double ropeLength, double sideLength)
        {
            double eaten = Math.PI * ropeLength * ropeLength;
            double farm = sideLength * sideLength;
            
            if (ropeLength > sideLength/2)
            {
                // cut the overlimiting pieces
                double d = sideLength / 2;
                double acos = (Math.PI / 2) - Math.Atan((d / ropeLength) / Math.Sqrt(1 - (d / ropeLength) * (d / ropeLength)));
                double x = 2 * acos;
                double s = 4 * (0.5 * ropeLength * ropeLength * (x - Math.Sin(x)));
                eaten -= s;

            }
            if (eaten >= farm)
                Console.WriteLine($"Goat has destroyed your farm, lol");
            else
                Console.WriteLine("Goat has eaten {0:0.##} square ones of your farm", eaten);
        }
    }
}
