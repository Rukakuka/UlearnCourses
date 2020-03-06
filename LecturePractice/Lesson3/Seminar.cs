// <Summary>
// Задачи на семинар
// Эти задачи можно использовать для самостоятельного решения или для решения на семинарах. Пожалуйста,
// не публикуйте решения задач в комментариях.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lesson3
{

    public static class Seminar
    {
        // <Summary>
        // Cond1.Дана начальная и конечная клетки на шахматной доске.
        // Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?
        // </Summary>
        public enum ChessFigures
        {
            King,
            Queen,
            Rook,
            Bishop,
            Knight,
            Pawn
        }        
        public static void Chess(ChessFigures figure, string from, string to)
        {
            Console.WriteLine(figure.ToString() + " : {0}-{1} {2}", from, to, IsCorrectMove(figure, from, to));
        }
        private static bool IsCorrectMove(ChessFigures figure, string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            return figure switch
            {
                ChessFigures.King   =>  (dy == 1 && dx == 1) || (dy == 0 && dx == 1) || (dx == 0 && dy == 1),
                ChessFigures.Queen  =>  (dx == dy && dx != 0) || (dy == 0 && dx != 0) || (dx == 0 && dy != 0),
                ChessFigures.Rook   =>  (dy == 0 && dx != 0) || (dx == 0 && dy != 0),    
                ChessFigures.Bishop =>  (dx == dy && dx != 0),
                ChessFigures.Knight =>  (dx != dy && ((dx == 2 && dy == 1) || (dy == 2 && dx == 1))),
                ChessFigures.Pawn   =>  throw new NotImplementedException(),
                _ => throw new ArgumentException(),
            };
        }
        // <Summary>
        // Cond2.Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, 
        // если его разрешается поворачивать на 90 градусов?
        // </Summary>
        public static void FitTheBlock(int x, int y, int z, int a, int b)
        {
            Console.WriteLine(CheckFit(x, y, z, a, b) ? "BLock fits" : "Block do not fit");

        }
        private static bool CheckFit(int x, int y, int z, int a, int b)
        {
            return CheckTwoSides(x, y, a, b) | CheckTwoSides(x, z, a, b) | CheckTwoSides(y, z, a, b);

            static bool CheckTwoSides(int side1, int side2, int a, int b)
            {
                return (side1 <= a && side2 <= b) || (side1 <= b && side2 <= a);
            }
        }
        // <Summary>
        // Cond3. 1493. В одном шаге от счастья
        // Дан номер трамвайного билета, 
        // в котором суммы первых трёх цифр и последних трёх цифр отличаются на 1 
        // (но не сказано, в какую сторону). Правда ли, что предыдущий или следующий билет счастливый?
        // </Summary>
        public static void LuckyTicket(int number)
        {
            Console.WriteLine(CheckLucky(number + 1) || CheckLucky(number - 1) ? "Yes" : "No");

            static bool CheckLucky(int number)
            {
                if (number < 0 || number > 999999)
                    throw new ArgumentException();

                int right = number % 1000;
                int left = number / 1000;

                return GetSum(left) == GetSum(right);
            }

            static int GetSum(int value)
            {
                var hunderets = value / 100;
                var decimals = (value % 100) / 10;
                var ones = value % 10;
                return ones + decimals + hunderets;
            }
        }
    }
}
