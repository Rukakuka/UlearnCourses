// <Summary>
// Преобразование строки в число
// Вася написал код, прибавляющий к числу единичку, но он опять не работает :(
// Немедленно помогите Васе, иначе он решит, что программирование слишком сложно для него!
// </Summary>


using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture1
{
    public class Task5
    {
        public static void VasyaEdinichka()
        {
            string doubleNumber = "894376.243643";
            double number = Double.Parse(doubleNumber); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);
        }
    }
}
