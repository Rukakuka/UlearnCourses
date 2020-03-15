using System;

namespace LecturePractice
{
    class Program
    {
        static void Main(string[] args)
        
        {
            var s = Lecture6.Task2.OptimizeContacts(new System.Collections.Generic.List<string> { "Юрий:dolg @rukiy.ru", "GGGG:ssss@rukiy.ru", "Юрий:aaaaa@rukiy.ru" });
            foreach (var i in s)
            {
                var kvp = i.Value;
                foreach (var j in kvp)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine(s);
            Console.WriteLine("Hello World!");
        }
    }
}
