using System;
using System.Threading;

namespace Calculator
{
    class Output
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Console Calculator!");
            Dashes();
        }
        public static void InputValue(int value)
        {
            if (value == 1)
            {
                Console.Write("Please enter the first number: ");
            }
            else if (value == 2)
            {
                Console.Write("Please enter the second number: ");
            }
        }
        public static void OperatorChoice()
        {
            Console.WriteLine("Please choose from the following operators:");
            Console.WriteLine("a - Addition\nb - Subtraction\nc - Multiplication\nd - Division");
        }
        public static void RunAgain()
        {
            Console.WriteLine("Would you like to carry out another calculation?");
            Console.Write("Please select y / n: ");
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
