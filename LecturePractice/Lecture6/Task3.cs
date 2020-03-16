// <Summary>
// Снова незнакомка
// Незнакомка вернулась!
// На рабочем столе своего ноутбука Вася обнаружил огромный файл, начинающийся так:
// push Привет! Это снова я! Пока!
// pop 5
// push Как твои успехи? Плохо?
// push qwertyuiop
// push 1234567890
// pop 26
// ...
// Да, кажется предыдущая программа по расшифровке шифра не понадобится — незнакомка не повторяется...
// Вася где-то слышал, что pop и push — это операции работы со стеком.Видимо, тут нужно действовать 
// по аналогии — push дописывает указанную строку в конец текста, а pop удаляет из конца указанное количество символов.
// Попробовав выполнить первые шесть операций, Вася получил текст:
// ** Привет! Это снова я! Как твои успехи? ** 
// Видимо, чтобы прочитать второе послание незнакомки, нужно выполнить все операции из файла. 
// Но файл слишком большой, тут без программы-декодировщика не обойтись!
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture6
{
    public static class Task3
    {
        public static string ApplyCommands(string[] commands)
        {
            var sb = new StringBuilder();
            foreach (var cmd in commands)
            {
                if (cmd.Contains("pop"))
                {
                    var toRemove = Int32.Parse(cmd.Remove(0, 4));                    
                    sb.Remove(sb.Length - toRemove, toRemove);
                    continue;
                }
                if (cmd.Contains("push"))
                    sb.Append(cmd.Remove(0,5));
            }
            return sb.ToString();
        }

    }
}
