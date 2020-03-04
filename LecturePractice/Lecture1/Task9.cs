// <Summary>
// Разыскиваются методы! 
// Напишите тело метода так, чтобы он возвращал вторую половину строки text, из которой затем удалены пробелы.
// Можете считать, что text всегда четной длины.
// Всю информацию о доступных методах класса String вы можете прочитать в официальной документации.NET
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture1
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
