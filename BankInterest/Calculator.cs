using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterest
{
    public static class Calculator
    {
        public static double Calculate(string userInput)
        {
            string[] depositInfo = userInput.Split(' ');

            double amount = Double.Parse(depositInfo[0]);
            double percent = Double.Parse(depositInfo[1]);
            int months = Int32.Parse(depositInfo[2]);

            if (amount <= 0 || percent < 0 || months < 0)
                throw new ArgumentException();
            if (months == 0)
                return amount;

            double deposit = Calculate(amount, percent, months);
            return deposit;
        }

        private static double Calculate(double amount, double percent, int month)
        {
            amount += amount * ((double)1 / 12) * (percent / 100);
            if (month != 1)
            {
                // step in till we hit the first month
                amount = Calculate(amount, percent, month - 1);
                return amount;
            }
            else
                // then return from the deep
                return amount;
        }
    }
}
