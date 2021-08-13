using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            int input1;
            int input2;
            string choice;
            string response;
            bool validation = true;
         
            Output.Message("Welcome to the Console Calculator!");
            Output.Dashes();
            while (validation)
            {
                Output.MessageSameLine("Please enter the first number: ");
                input1 = Convert.ToInt32(Console.ReadLine());
                Output.MessageSameLine("Please enter the second number: ");
                input2 = Convert.ToInt32(Console.ReadLine());
                Output.Dashes();
                Output.Message("Please choose from the following operators:");
                Output.Message("a - Addition\nb - Subtraction\nc - Multiplication\nd - Division");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        int addition = Arithmatic.Addition(input1, input2);
                        Output.UserChoice(choice);
                        Output.Message($"{input1} + {input2} = {addition}");
                        break;
                    case "b":
                        int subtraction = Arithmatic.Subtraction(input1, input2);
                        Output.UserChoice(choice);
                        Output.Message($"{input1} - {input2} = {subtraction}");
                        break;
                    case "c":
                        int multiplication = Arithmatic.Multiplication(input1, input2);
                        Output.UserChoice(choice);
                        Output.Message($"{input1} x {input2} = {multiplication}");
                        break;
                    case "d":
                        int division = Arithmatic.Division(input1, input2);
                        Output.UserChoice(choice);
                        Output.Message($"{input1} / {input2} = {division}");
                        break;
                }
                Output.Message("Would you like to carry out another calculation? Please select y / n.");
                response = Console.ReadLine();
                if (response == "y")
                {
                    Console.Clear();
                }
                else
                {
                    validation = false;
                    Output.Message("Thank you for using the Console Calculator.");
                    Output.Message("Have a nice day!");
                }
            }
        }
    }
    public class Output
    {
        public static void Message(string output)
        {
            Console.WriteLine($"{output}");  
        }
        public static void MessageSameLine(string output)
        {
            Console.Write($"{output}");
        }
        public static void Dashes()
        {
            Console.WriteLine("-------------------------------------------");
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
        public static void UserChoice(string choice)
        {
            Message($"You chose: {choice}");
            Dashes();
            Loading();
        }
    }
    public class Arithmatic
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
    }
}