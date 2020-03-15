// <Summary>
// Шифр незнакомки 
// Вася долго лежал на пляже, пытаясь понять, что бы это значило. Дошло до того, 
// что он перегрелся на солнце и у него закружилась голова, 
// но как раз благодаря этому он и понял как разгадать шифр:
// Нужно выписать все слова, начинающиеся с большой буквы, в порядке обратном тому, как они встречались в тексте.
// Вася все еще надеется, что незнакомка пришлет ему еще одно послание.
// А чтобы приготовиться к этому моменту, решил написать программу, расшифровывающую ее шифр.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture6
{
    public static class Task1
    {
        public static string DecodeMessage(string[] lines)
        {
            string message = "";
            
            foreach (var line in lines)
            {
                var words = line.Split(' ');
                foreach (var word in words)
                    if (!String.IsNullOrEmpty(word) && Char.IsUpper(word[0]))
                        message = message.Insert(0, word + " ");
            }
            return message.ToString();
        }
    }
}
