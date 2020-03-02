using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson1
{
    public class Task7
    {
        public static void DobryRabotodatel()
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }

        public static String GetGreetingMessage(string name, double salary)
        {
            return $"Hello, {name.ToString()}, your salary is {((int)Math.Ceiling(salary)).ToString()}"; 
        }
    }
}
