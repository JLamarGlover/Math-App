using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyCalc
    {
        string input;
        int n;
        int x;
        public void AskUser()
        {
            Console.WriteLine("Which type of Mathmatical action would you like to use?");
            input = Console.ReadLine();
            Console.WriteLine("Insert first number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number");
            x = Convert.ToInt32(Console.ReadLine());
           
        }

        public double calculate()
        {
            AskUser();

            if (input == "adding" || input == "+")
            {
                Console.WriteLine($"Addition Selected:   {n + x}");
                Console.ReadLine();
                return calculate();
            }


            else if (input == "subtracting" || input == "-")
            {
                Console.WriteLine($"Subtraction Selected:   {n - x}");
                Console.ReadLine();
                return calculate();

            }

            else if (input == "multiplying" || input == "*")
            {
                Console.WriteLine($"Multiplication Selected:  {n * x}");
                Console.ReadLine();
                return calculate();

            }

            else if (input == "dividing" || input == "/")
            {
                Console.WriteLine($"Divison Selected:  {n / x}");
                Console.ReadLine();
                return calculate();
            }

            else
            {
                Console.WriteLine("Thanks for stopping by!");
                Console.ReadLine();

            }
            return x;
        }
    }
}
