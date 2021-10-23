using System;

namespace MyCalc
{
    public class Calculator
    {
        private static bool numberIsFound;
        private static decimal result;
        private static decimal number;
        private static string input;

        public static void Use()
        {
            while (true)
            {
                Console.Clear();
                Print.Text("\tcalculator\n", ConsoleColor.Cyan);
                Print.Text("\nuse [=] to get a result or\ninterrupt the current input\n\n", ConsoleColor.Blue);

                if (result == 0)
                {
                    PerformOperation();
                    result = number;
                }

                else Print.Text($"\t\t{result}\n", ConsoleColor.Green);

                while (input != "=")
                {
                    Print.Text("+  -  *  /\t", ConsoleColor.DarkYellow);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    input = Console.ReadLine();
                    Console.ResetColor();

                    if (input == "+" || input == "-" || input == "*" || input == "/")
                        PerformOperation(input);

                    else if (input == "=")
                        Print.Text($"\nresult:\t\t{result = Math.Round(result, 15)}\n", ConsoleColor.Green);

                    else ClearLine();
                }

                do
                {
                    Question("\nContinue using the calculator?");

                    if (input != "y" && input != "n")
                    {
                        Print.Text("y - continue\a".PadLeft(56, ' ') + "\n", ConsoleColor.Red);
                        Print.Text("n - exit\a".PadLeft(52, ' '), ConsoleColor.Red);
                    }
                }
                while (input != "y" && input != "n");

                if (input == "y")
                {
                    do
                    {
                        Question("\nSave current result as starting number?");

                        if (input != "y" && input != "n")
                        {
                            Print.Text($"\t\t\t\t\t\t    y - start from {result}\a\n", ConsoleColor.Red);
                            Print.Text("n - start from 0\a".PadLeft(69, ' '), ConsoleColor.Red);
                        }
                    }
                    while (input != "y" && input != "n");

                    if (input == "n")
                    {
                        result = 0;
                        continue;
                    }
                }

                if (input == "n") return;
            }
        }

        private static void PerformOperation(string mathOperator = null)
        {
            do
            {
                Print.Text("input:\t\t");
                input = Console.ReadLine();
                numberIsFound = decimal.TryParse(input, out number);

                if (input == "=")
                {
                    Print.Text("\ninput interrupted\n", ConsoleColor.Blue);

                    if (mathOperator != null)
                        Print.Text($"result:\t\t{result = Math.Round(result, 15)}\n", ConsoleColor.Green);

                    break;
                }

                else
                {
                    if (number == 0)
                    {
                        if (!numberIsFound) ClearLine();
                        else
                        {
                            ClearLine();
                            numberIsFound = false;
                        }
                    }

                    else if (mathOperator != null)
                    {
                        if (mathOperator == "+") result += number;
                        if (mathOperator == "-") result -= number;
                        if (mathOperator == "*") result *= number;
                        if (mathOperator == "/") result /= number;
                    }
                }
            }
            while (!numberIsFound);
        }

        private static void Question(string text)
        {
            Print.Text(text);
            Print.Text(" [y] ", ConsoleColor.Green);
            Print.Text("/");
            Print.Text(" [n] ", ConsoleColor.Green);
            Print.Text(": ");

            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine().ToLower();
            Console.ResetColor();
        }

        private static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
