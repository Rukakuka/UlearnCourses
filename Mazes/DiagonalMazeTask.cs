using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            Direction dir = WhatFirstMove(width, height);
            int bigStep = (int)Math.Round((double)Math.Max(width, height) / Math.Min(width, height));

            for (int i = 0; i < Math.Min(width, height) - 3; i++)
            {
                Move(robot, bigStep, dir);
                dir = Turn(dir);
                Move(robot, 1, dir);
                dir = Turn(dir);
            }
            Move(robot, bigStep, dir);
        }

        private static void Move(Robot robot, int steps, Direction direction)
        {
            for (int i = 0; i < steps; i++)
                robot.MoveTo(direction);
        }
        private static Direction WhatFirstMove(int width, int height)
        {
            if (width > height)
                return Direction.Right;
            else
                return Direction.Down;
        }
        private static Direction Turn(Direction direction)
        {
            if (direction == Direction.Down) return Direction.Right;
            if (direction == Direction.Right) return Direction.Down;
            throw new NotImplementedException();
        }
    }
}