// <Summary>
// Сделай то, не знаю что
// Задача-загадка.Задания нет — так и задумано.Не бойтесь экспериментировать.
// Запустите код на выполнение и внимательно изучите ошибки.
// Ориентируясь на текст ошибок попробуйте сами понять, что нужно сделать.
// Эта задача требует смекалки и упорства!
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson2
{
    class Task3
    {
        static object Decode(object obj)
        {
            string cleaned = obj.ToString();

            foreach (var ch in new char[] { '.', ',' })
                cleaned = cleaned.Replace(ch.ToString(), "");
            var num = Int32.Parse(cleaned);
            //var decoded = num > 1024 ? num-1024 : num;
            var decoded = num % 1024;
            return decoded;
        }
    }
}
