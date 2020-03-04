// <Summary>
// Использование var
// С прибавлением единицы все оказалось просто.Казалось бы прибавление к числу половинки должно быть не сложнее...
// Подумайте, как так получилось, что казалось бы корректная программа не работает.Исправьте первую строчку программы так,
// чтобы она компилировалась и выводила на консоль ожидаемый ответ — 5.5.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture1
{
    public class Task6
    {
        static public void Add()
        {
            double a = 5; // ← исправьте эту строку
            a += 0.5;
            Console.WriteLine(a);
        }
    }
}
