using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple .NET Calculator");
            Console.WriteLine("You can perform +, -, *, / operations");
            Console.WriteLine("Type 'exit' anytime to quit.\n");

            bool running = true;

            while (running)
            {
                Console.Write("Enter first number (or 'exit'): ");
                string input1 = Console.ReadLine();

                if (input1?.Trim().ToLower() == "exit")
                    break;

                if (!double.TryParse(input1, out double num1))
                {
                    Console.WriteLine("Invalid number. Try again.\n");
                    continue;
                }

                Console.Write("Enter operation (+, -, *, /): ");
                string opInput = Console.ReadLine();

                if (string.IsNullOrEmpty(opInput))
                {
                    Console.WriteLine("Invalid operation. Try again.\n");
                    continue;
                }

                char op = opInput[0];

                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();

                if (!double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Invalid number. Try again.\n");
                    continue;
                }

                double result = 0;
                bool validOp = true;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.\n");
                            validOp = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.\n");
                        validOp = false;
                        break;
                }

                if (validOp)
                    Console.WriteLine($"Result: {result}\n");
            }

            Console.WriteLine("Exiting Calculator. Goodbye!");
        }
    }
}
