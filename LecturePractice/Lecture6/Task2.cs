// <Summary>
// Полезные знакомства
// В отпуске Вася не тратил время зря, а заводил новые знакомства. Он знакомился с 
// другими крутыми программистами, отдыхающими с ним в одном отеле, и записывал их email-ы.
// В его дневнике получилось много записей вида<name>:<email>.
// Чтобы искать записи было быстрее, он решил сделать словарь, в котором по двум первым буквам имени можно найти все записи его дневника.
// Вася уже написал функцию GetContacts, которая считывает его каракули из блокнота. Помогите ему сделать все остальное!
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture6
{
    public static class Task2
    {
        public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var contact in contacts)
            {
                var key = contact[0].ToString()  + (contact[1].ToString().Equals(":") ? "" : contact[1].ToString());
                if (!dictionary.ContainsKey(key))
                    dictionary.Add(key, new List<string>());
                dictionary[key].Add(contact);
            }
            return dictionary;
        }
    }
}
