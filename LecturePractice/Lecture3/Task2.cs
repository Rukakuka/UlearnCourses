// <Summary>
// Ход ферзя
// Вася решил научить своего младшего брата играть в шахматы.
// Но вот беда, брат еще слишком мал и никак не может запомнить как ходит ферзь.
// Как настоящий программист, Вася решил автоматизировать ручной труд по обучению начинающих шахматистов.
// Помогите ему написать программу, которая по шахматному ходу определяет корректный ли это ход ферзя.
// Координаты исходной и конечной позиции хода передаются строкой в обычной шахматной нотации, например, "a1".
// Как обычно, постарайтесь поразить Васю красотой и простотой получившегося кода!
// В любой непонятной ситуации пользуйтесь подсказками! Они бесплатны :)
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture3
{
    public static class Task2
    {
        public static void Chess()
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }
        private static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

            //     diagonal            horizontal          OR      vertical     
            return (dx == dy && dx!=0) ? true : ((dy == 0 && dx != 0) || (dx == 0 && dy != 0)) ? true : false;
        }

    }
}
