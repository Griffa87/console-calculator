using System;
using System.Threading;

namespace Calculator
{
    //Class responsible for all output including exception handling.
    class Output
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Console Calculator!");
            Dashes();
        }
        public static int InputValue(int value)
        {
            //First number input.
            if (value == 1)
            {
                int userInput;

                Console.Write("Please enter the first whole number: ");
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Write("Invalid input! Please enter a whole number: ");
                }
                return userInput;
            }
            //Second number input.
            else
            {
                Console.Write("Please enter the second whole number: ");
                int userInput;
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Write("Invalid input! Please enter a whole number: ");
                }
                return userInput;
            }
        }
        public static string OperatorChoice()
        {
            string userChoice;
            
            Console.WriteLine("Please choose from the following operators:");
            Console.WriteLine("a - Addition\nb - Subtraction\nc - Multiplication\nd - Division");
            Console.Write($"Your choice is: ");
            userChoice = Console.ReadLine();
            while (userChoice != "a" && userChoice != "b" && userChoice != "c" && userChoice != "d")
            {
                Console.Write("Invalid choice! Please select a valid option: ");
                userChoice = Console.ReadLine();
            }
            return userChoice;
        }
        public static string RunAgain()
        {
            string userChoice;

            Console.WriteLine("Would you like to carry out another calculation?");
            Console.Write("Please select y / n: ");
            userChoice = Console.ReadLine();
            while (userChoice != "y" && userChoice != "n")
            {
                Console.Write("Invalid choice! Please select a valid option: ");
                userChoice = Console.ReadLine();
            }
            return userChoice;
        }
        public static void FarewellMessage()
        {
            Console.WriteLine("Thank you for using the Console Calculator.");
            Console.WriteLine("Have a nice day!");
        }
        public static void Dashes()
        {
            Console.WriteLine("------------------------------------------------");
        }
        public static void Loading()
        {
            Console.Write("Processing now");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
            }
            Console.WriteLine();
        }
    }
}
