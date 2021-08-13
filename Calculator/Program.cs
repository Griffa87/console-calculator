using System;

namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            bool running = true;

            Output.WelcomeMessage();
            while (running)
            {
                Output.InputValue(1);
                int input1 = ExceptionHandler.IsInt();
                Output.InputValue(2);
                int input2 = ExceptionHandler.IsInt();
                Output.Dashes();
                Output.OperatorChoice();
                Arithmetic.Answer(input1, input2);
                Output.RunAgain();
                string response = Console.ReadLine();
                if (response == "y")
                {
                    Console.Clear();
                }
                else
                {
                    running = false;
                    Output.Dashes();
                    Output.FarewellMessage();
                }
            }
        }
    }   
}