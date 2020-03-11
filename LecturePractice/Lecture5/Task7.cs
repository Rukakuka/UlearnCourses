// <Summary>
// Возвести массив в степень
// Помогите Васе написать метод, который принимает массив int[], возводит все
// его элементы в заданную степень и возвращает массив с результатом этой операции.
// Исходный массив при этом должен остаться неизменным.
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
    public static class Task7
    {
        public static void ArrayPower()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            PrintArray(GetPoweredArray(arrayToPower, 1));

            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));

            // не забывайте про частные случаи:
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
            
        }

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            if (arr == null || arr.Length == 0)
                return new int[] { };

            var pow = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                pow[i] = (int)Math.Pow(arr[i], power);
            return pow;
        }
        public static void PrintArray(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
