using System;

namespace Calculator
{
    class ExceptionHandler
    {
        public static int IsInt()
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Invalid input! Please enter a number: ");
            }
            return userInput;             
        }
    }
}
