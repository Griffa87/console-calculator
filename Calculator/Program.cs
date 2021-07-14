using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)

        { 
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Welcome to my C# calculator!");
            Console.WriteLine("\nThis simple program will carry out basic math for you.");
            Console.WriteLine("Why dont you give it a try?");
            Console.WriteLine("\n------------------------------------------------------");
            Console.Write("Please enter the first number, then press <ENTER>: ");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a number!");
            }
            Console.Write("Now, please enter the second number, then press <ENTER>: ");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a number, then press <ENTER>");
            }
            Console.WriteLine("Please choose an operator to apply by typing the corresponding letter, then press <ENTER>:");
            Console.WriteLine("");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\ts - Subtraction");
            Console.WriteLine("\tm - Multiplication");
            Console.WriteLine("\td - Division");
            Console.WriteLine("");
            Console.Write("Your choice is: ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The answer is {num1 + num2}!");
                    break;
                case "s":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The answer is {num1 - num2}!");
                    break;
                case "m":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The answer is {num1 * num2}!");
                    break;
                case "d":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The answer is " + decimal.Divide(num1, num2));
                    break;
            }
            Console.ResetColor();
            Console.WriteLine("\n------------------------------------------------------");
        }
    }
}