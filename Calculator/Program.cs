using System;

namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            int input1;            //Users first number.
            int input2;            //Users second number.
            string choice;         //Users operator choice.
            string response;       //Users asked if they want to exit or calculate again.    
            bool running = true;

            Output.WelcomeMessage();
            while (running)
            {
                input1 = Output.InputValue(1);                
                input2 = Output.InputValue(2);               
                Output.LineBreak();
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
                    Output.LineBreak();
                    Output.FarewellMessage();
                }
            }
        }
    }   
}