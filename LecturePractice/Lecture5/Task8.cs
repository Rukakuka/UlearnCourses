// <Summary>
// Крестики - нолики
// Вам с Васей наконец-то надоело тренироваться на маленьких программках и вы взялись за настоящее дело! 
// Вы решили написать игру крестики-нолики!
// Начать было решено с подпрограммы, определяющей не закончилась ли уже игра, 
// а если закончилась, то кто выиграл.
// Методу GetGameResult передается поле, представленное массивом 3х3 из enum Markers. 
// Вам надо вернуть победителя CrossWin или CircleWin, если таковой имеется или Draw, 
// если выигрышной последовательности нет ни у одного, либо есть у обоих.
// Постарайтесь придумать красивое, понятное решение.
// Подумайте, как разбить задачу на более простые подзадачи.Попытайтесь выделить один 
// или два вспомогательных метода.
// Если вы в затруднении, воспользуйтесь подсказками (кнопка Get hint)
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
    public static class Task8
    {
        private enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        private enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void CrissCross()
        {
            Run("XXX OO. O.X");
            Run("XX. OOO .XX");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }
        private static GameResult GetGameResult(Mark[,] field)
        {
            var lines = GetAllLines(field);
            bool crossWins = false;
            bool circleWins = false;
            foreach (var line in lines)
            {
                var winner = CheckLineWinner(line);
                if (winner == Mark.Circle)
                    circleWins = true;
                if (winner == Mark.Cross)
                    crossWins = true;
            }
            return ParseWinner(crossWins, circleWins);
        }
        private static GameResult ParseWinner(bool cross, bool circle)
        {
            if (cross && circle || !cross && !circle)
                return GameResult.Draw;
            if (cross)
                return GameResult.CrossWin;
            if (circle)
                return GameResult.CircleWin;
            return GameResult.Draw;
        }
        private static Mark CheckLineWinner(Mark[] line)
        {
            for (int i = 0; i < line.Length - 1; i++)
                if (line[i] != line[i + 1])
                    return Mark.Empty;
            return line[0];
        }
        private static Mark[][] GetAllLines(Mark[,] field)
        {
            var length = field.GetLength(0);
            // Assuming field is square
            var lines = new Mark[2 * length + 2][];

            // get rows
            for (int row = 0; row < length; row++)
            {
                lines[row] = new Mark[length];
                for (int col = 0; col < length; col++)
                    lines[row][col] = field[row, col];
            }
            // get columns
            for (int row = 0; row < length; row++)
            {
                lines[row + length] = new Mark[length];
                for (int col = 0; col < length; col++)
                    lines[row + length][col] = field[col, row];
            }
            // get diagonals (only two)
            for (int row = 2 * length; row < 2 * length + 2; row++)
            {
                lines[row] = new Mark[length];
            }
            for (int item = 0; item < length; item++)
            {
                lines[2 * length][item] = field[item, item];
                lines[2 * length + 1][item] = field[item, length - 1 - item];
            }
            return lines;
        }
    }
}
