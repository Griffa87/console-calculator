using System;

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
            bool running = true;

            Output.WelcomeMessage();
            while (running)
            {
                input1 = Output.InputValue(1);                
                input2 = Output.InputValue(2);               
                Output.Dashes();
                choice = Output.OperatorChoice();
                Arithmetic.Answer(choice, input1, input2);
                response = Output.RunAgain();
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