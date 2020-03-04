using System;

namespace BankInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please enter your deposit info, delimiting it by spaces: Initial amount of money," +
                "then deposit percent, and then time span in months");
            var str = Console.ReadLine();
            var deposit = Calculator.Calculate(str);
            Console.WriteLine(deposit);
        }
    }
}
