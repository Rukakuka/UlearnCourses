// <Summary>
// Среднее трех
// Вы с Васей и Петей решили выбрать самые лучшие фотографии котиков в интернете.
// Для этого каждую фотографию каждый из вас оценил по стобалльной шкале.
// Естественно, тут же встал вопрос о том, как из трех оценок получить одну финальную.
// Вы опасаетесь, что каждый из вас сильно завысит оценку фотографиям своего котика. 
// Поэтому было решено в качестве финальной оценки брать не среднее арифметическое, 
// а медиану, то есть просто откинуть максимальную и минимальную оценки.
// Вася начал писать код выбора средней оценки из трех, но запутался в if-ах, и поэтому перепоручил эту задачу вам.
// Попробуйте не просто решить задачу, но и минимизировать количество проверок и максимально упростить условия проверок.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture3
{
    public static class Task3
    {
        public static void ThreeAverage()
        {
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));
        }

        public static int MiddleOf(int a, int b, int c)
        {
            int[] arr = new int[3] { a, b, c };
            Array.Sort(arr);
            return arr[arr.Length/2];
        }
    }
}
