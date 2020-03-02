using System;
using System.Collections.Generic;
using System.Text;

namespace ULearnCourses.Lesson1
{
    public class Task9
    {
        public static void LookingForMethods()
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
        public static String GetLastHalf(String str)
        {
            return str.Substring(str.Length / 2).Replace(" ","");
        }

    }
}
