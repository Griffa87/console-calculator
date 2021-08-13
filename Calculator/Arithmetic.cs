using System;

namespace Calculator
{
    class Arithmetic
    {
        public static int Addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static int Subtraction(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
        public static int Multiplication(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
        public static int Division(int a, int b)
        {
            int sum = a / b;
            return sum;
        }
        public static void Answer(int input1, int input2)
        {

            Console.Write("Your choice is: "); 
            string choice = Console.ReadLine();
            Output.Dashes();
            Output.Loading();
            switch (choice)
            {
                case "a":
                    int addition = Addition(input1, input2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{input1} + {input2} = {addition}");
                    Console.ResetColor();
                    break;
                case "b":
                    int subtraction = Subtraction(input1, input2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{input1} - {input2} = {subtraction}");
                    Console.ResetColor();
                    break;
                case "c":
                    int multiplication = Multiplication(input1, input2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{input1} x {input2} = {multiplication}");
                    Console.ResetColor();
                    break;
                case "d":
                    int division = Division(input1, input2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{input1} / {input2} = " + decimal.Divide(input1, input2));
                    Console.ResetColor();
                    break;
            }
        }
    }
}
