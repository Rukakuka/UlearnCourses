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
