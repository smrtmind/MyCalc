using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (input.ToLower() != "y")
            {
                byte menuChoice;
                double result = 0;
                double number, number1, percent, power;
                bool numberIsFound;

                do
                {
                    //print huge starting options
                    Print.MainMenuOptions();

                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine();
                    byte.TryParse(input, out menuChoice);
                    Console.ResetColor();

                    //calculator
                    if (menuChoice == 1)
                    {
                        while (true)
                        {
                            Console.Clear();
                            //method print is using all over this code
                            //it gives an opportunity to change color of the text or make it slow on printing for each string
                            //and do this with in one string of code
                            Print.Text("\tcalculator\n", ConsoleColor.Cyan);
                            Print.Text("\nuse [=] to get a result or\ninterrupt the current input\n\n", ConsoleColor.Blue);

                            if (result == 0)
                            {
                                do
                                {
                                    Print.Text("input:\t\t");
                                    input = Console.ReadLine();
                                    numberIsFound = double.TryParse(input, out number);

                                    if (input == "=")
                                    {
                                        Print.Text("\ninput interrupted\n", ConsoleColor.Blue);
                                        break;
                                    }
                                }
                                while (!numberIsFound);

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
                                    Print.Text($"\nresult:\t\t{result}\n", ConsoleColor.Green);

                                else
                                    Print.Text("unknown operator\a".PadLeft(33, ' ') + "\n", ConsoleColor.Red);
                            }

                            do
                            {
                                Print.Text("\nContinue using the calculator?");
                                Print.Text(" [y] ", ConsoleColor.Green);
                                Print.Text("/");
                                Print.Text(" [n] ", ConsoleColor.Green);
                                Print.Text(": ");

                                Console.ForegroundColor = ConsoleColor.Green;
                                input = Console.ReadLine();
                                Console.ResetColor();

                                if (input.ToLower() != "y" && input.ToLower() != "n")
                                {
                                    Print.Text("y - continue\a".PadLeft(56, ' ') + "\n", ConsoleColor.Red);
                                    Print.Text("n - exit\a".PadLeft(52, ' '), ConsoleColor.Red);
                                    continue;
                                }
                            }
                            while (input.ToLower() != "y" && input.ToLower() != "n");

                            if (input.ToLower() == "y")
                            {
                                do
                                {
                                    Print.Text("\nSave current result as starting number?");
                                    Print.Text(" [y] ", ConsoleColor.Green);
                                    Print.Text("/");
                                    Print.Text(" [n] ", ConsoleColor.Green);
                                    Print.Text(": ");

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    input = Console.ReadLine();
                                    Console.ResetColor();

                                    if (input.ToLower() != "y" && input.ToLower() != "n")
                                    {
                                        Print.Text($"\t\t\t\t\t\t    y - start from {result}\a\n", ConsoleColor.Red);
                                        Print.Text("n - start from 0\a".PadLeft(69, ' '), ConsoleColor.Red);
                                        continue;
                                    }
                                }
                                while (input.ToLower() != "y" && input.ToLower() != "n");

                                if (input.ToLower() == "y") continue;

                                if (input.ToLower() == "n")
                                {
                                    result = 0;
                                    continue;
                                }
                            }

                            if (input.ToLower() == "n") break;
                        }

                        void PerformOperation(string mathOperator)
                        {
                            do
                            {
                                Print.Text("input:\t\t");
                                input = Console.ReadLine();
                                numberIsFound = double.TryParse(input, out number);

                                if (input == "=")
                                {
                                    Print.Text("\ninput interrupted\n", ConsoleColor.Blue);
                                    Print.Text($"result:\t\t{result}\n", ConsoleColor.Green);
                                    break;
                                }

                                else
                                {
                                    if (mathOperator == "+") result += number;
                                    if (mathOperator == "-") result -= number;
                                    if (mathOperator == "*") result *= number;
                                    if (mathOperator == "/")
                                    {
                                        if (number == 0)
                                            Print.Text("division by zero is not possible\a".PadLeft(49, ' ') + "\n", ConsoleColor.Red);

                                        else result /= number;
                                    }
                                        
                                }
                            }
                            while (!numberIsFound || number == 0 && mathOperator == "/");
                        }
                    }

                    //square
                    else if (menuChoice == 2)
                    {
                        Console.Clear();
                        Print.Text("\tsquare of a number\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Pow(number, 2)}\n", ConsoleColor.Green);
                    }

                    //cube
                    else if (menuChoice == 3)
                    {
                        Console.Clear();
                        Print.Text("\tcube of a number\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Pow(number, 3)}\n", ConsoleColor.Green);
                    }

                    //number to a power
                    else if (menuChoice == 4)
                    {
                        Console.Clear();
                        Print.Text("\traise a number to a power\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        power = GetNumber("power:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Pow(number, power)}\n", ConsoleColor.Green);
                    }

                    //square root
                    else if (menuChoice == 5)
                    {
                        Console.Clear();
                        Print.Text("\tsquare root of a number\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Sqrt(number)}\n", ConsoleColor.Green);
                    }

                    //cube root
                    else if (menuChoice == 6)
                    {
                        Console.Clear();
                        Print.Text("\tcube root of a number\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Cbrt(number)}\n", ConsoleColor.Green);
                    }

                    //percentage
                    else if (menuChoice == 7)
                    {
                        do
                        {
                            //print starting options
                            Print.PercentageOptions();

                            Console.ForegroundColor = ConsoleColor.Green;
                            input = Console.ReadLine();
                            byte.TryParse(input, out menuChoice);
                            Console.ResetColor();

                            if (input.ToLower() == "<") break;

                            switch (menuChoice)
                            {
                                case 1:
                                    Console.Clear();
                                    Print.Text("\twhat is ... % of number ...\n\n", ConsoleColor.Cyan);
                                    percent = GetNumber("input %:\t");
                                    number = GetNumber("input number:\t");

                                    result = (number / 100) * percent;
                                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Print.Text("\twhat % is number ... of number ...\n\n", ConsoleColor.Cyan);
                                    number = GetNumber("input number1:\t");
                                    number1 = GetNumber("input number2:\t");

                                    result = 100 / (number1 / number);
                                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;

                                case 3:
                                    Console.Clear();
                                    Print.Text("\tadd ... % to the number ...\n\n", ConsoleColor.Cyan);
                                    percent = GetNumber("input %:\t");
                                    number = GetNumber("input number:\t");

                                    result = ((number / 100) * percent) + number;
                                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;

                                case 4:
                                    Console.Clear();
                                    Print.Text("\tsubtract ... % from the number ...\n\n", ConsoleColor.Cyan);
                                    percent = GetNumber("input %:\t");
                                    number = GetNumber("input number:\t");

                                    result = number - ((number / 100) * percent);
                                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;
                            }
                        }
                        while (menuChoice <= 0 || menuChoice > 4);
                    }

                    //sine
                    else if (menuChoice == 8)
                    {
                        Console.Clear();
                        Print.Text("\tsine of an angle\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Sin((number) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //cosine
                    else if (menuChoice == 9)
                    {
                        Console.Clear();
                        Print.Text("\tcosine of an angle\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Cos((number) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //tangent
                    else if (menuChoice == 10)
                    {
                        Console.Clear();
                        Print.Text("\ttangent of an angle\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Tan((number) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //sinh
                    else if (menuChoice == 11)
                    {
                        Console.Clear();
                        Print.Text("\thyperbolic sine of an angle\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Sinh(number)}\n", ConsoleColor.Green);
                    }

                    //cosh
                    else if (menuChoice == 12)
                    {
                        Console.Clear();
                        Print.Text("\thyperbolic cosine of an angle\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Cosh(number)}\n", ConsoleColor.Green);
                    }

                    //tanh
                    else if (menuChoice == 13)
                    {
                        Console.Clear();
                        Print.Text("\thyperbolic tangent of an angle\n\n", ConsoleColor.Cyan);
                        number = GetNumber("input:\t\t");
                        Print.Text($"\nresult:\t\t{Math.Tanh(number)}\n", ConsoleColor.Green);
                    }

                    else if (input.ToLower() == "<") break;
                }
                while (menuChoice <= 0 || menuChoice > 13);
                
                //stop the program and exit
                if (input.ToLower() == "<")
                {
                    //print the animation
                    Print.ProgramShutDown();
                    break;
                }

                do
                {
                    Print.Text("\nExit the program?");
                    Print.Text(" [y] ", ConsoleColor.Green);
                    Print.Text("/");
                    Print.Text(" [n] ", ConsoleColor.Green);
                    Print.Text(": ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine();
                    Console.ResetColor();

                    if (input.ToLower() != "y" && input.ToLower() != "n")
                    {
                        Print.Text("y - exit\a".PadLeft(39, ' ') + "\n", ConsoleColor.Red);
                        Print.Text("n - return to main menu\a".PadLeft(54, ' '), ConsoleColor.Red);
                        continue;
                    }
                }
                while (input.ToLower() != "y" && input.ToLower() != "n");

                if (input.ToLower() == "y") Print.ProgramShutDown();
            }
        }      
        
        internal static double GetNumber(string text)
        {
            string keyboardInput = string.Empty;
            double number;
            bool numberFound;

            do
            {
                Print.Text(text);
                keyboardInput = Console.ReadLine();
                numberFound = double.TryParse(keyboardInput, out number);
            }
            while (!numberFound);

            return number;
        }
    }
}
