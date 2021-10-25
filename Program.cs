using System;

namespace MyCalc
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
                double number, number1, percent;

                do
                {
                    //print huge starting options
                    Print.MainMenuOptions();

                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine();
                    byte.TryParse(input, out menuChoice);
                    Console.ResetColor();

                    //calculator
                    if (menuChoice == 1) Calculator.Use();

                    //square
                    else if (menuChoice == 2)
                    {
                        Function.PrintTitle("\tsquare of a number\n\n");
                        Print.Text($"\nresult:\t\t{Math.Pow(Function.GetNumber(), 2)}\n", ConsoleColor.Green);
                    }

                    //cube
                    else if (menuChoice == 3)
                    {
                        Function.PrintTitle("\tcube of a number\n\n");
                        Print.Text($"\nresult:\t\t{Math.Pow(Function.GetNumber(), 3)}\n", ConsoleColor.Green);
                    }

                    //number to a power
                    else if (menuChoice == 4)
                    {
                        Function.PrintTitle("\traise a number to a power\n\n");
                        Print.Text($"\nresult:\t\t{Math.Pow(Function.GetNumber(), Function.GetNumber())}\n", ConsoleColor.Green);
                    }

                    //square root
                    else if (menuChoice == 5)
                    {
                        Function.PrintTitle("\tsquare root of a number\n\n");
                        Print.Text($"\nresult:\t\t{Math.Sqrt(Function.GetNumber())}\n", ConsoleColor.Green);
                    }

                    //cube root
                    else if (menuChoice == 6)
                    {
                        Function.PrintTitle("\tcube root of a number\n\n");
                        Print.Text($"\nresult:\t\t{Math.Cbrt(Function.GetNumber())}\n", ConsoleColor.Green);
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

                            //switch (menuChoice)
                            //{
                            //    case 1:
                            //        Console.Clear();
                            //        Print.Text("\twhat is ... % of number ...\n\n", ConsoleColor.Cyan);
                            //        percent = GetNumber("input %:\t");
                            //        number = GetNumber("input number:\t");

                            //        result = (number / 100) * percent;
                            //        Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                            //        break;

                            //    case 2:
                            //        Console.Clear();
                            //        Print.Text("\twhat % is number ... of number ...\n\n", ConsoleColor.Cyan);
                            //        number = GetNumber("input number1:\t");
                            //        number1 = GetNumber("input number2:\t");

                            //        result = 100 / (number1 / number);
                            //        Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                            //        break;

                            //    case 3:
                            //        Console.Clear();
                            //        Print.Text("\tadd ... % to the number ...\n\n", ConsoleColor.Cyan);
                            //        percent = GetNumber("input %:\t");
                            //        number = GetNumber("input number:\t");

                            //        result = ((number / 100) * percent) + number;
                            //        Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                            //        break;

                            //    case 4:
                            //        Console.Clear();
                            //        Print.Text("\tsubtract ... % from the number ...\n\n", ConsoleColor.Cyan);
                            //        percent = GetNumber("input %:\t");
                            //        number = GetNumber("input number:\t");

                            //        result = number - ((number / 100) * percent);
                            //        Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                            //        break;
                            //}
                        }
                        while (menuChoice <= 0 || menuChoice > 4);
                    }

                    //sine
                    else if (menuChoice == 8)
                    {
                        Function.PrintTitle("\tsine of an angle\n\n");
                        Print.Text($"\nresult:\t\t{Math.Sin((Function.GetNumber()) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //cosine
                    else if (menuChoice == 9)
                    {
                        Function.PrintTitle("\tcosine of an angle\n\n");
                        Print.Text($"\nresult:\t\t{Math.Cos((Function.GetNumber()) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //tangent
                    else if (menuChoice == 10)
                    {
                        Function.PrintTitle("\ttangent of an angle\n\n");
                        Print.Text($"\nresult:\t\t{Math.Tan((Function.GetNumber()) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //sinh
                    else if (menuChoice == 11)
                    {
                        Function.PrintTitle("\thyperbolic sine of an angle\n\n");
                        Print.Text($"\nresult:\t\t{Math.Sinh(Function.GetNumber())}\n", ConsoleColor.Green);
                    }

                    //cosh
                    else if (menuChoice == 12)
                    {
                        Function.PrintTitle("\thyperbolic cosine of an angle\n\n");
                        Print.Text($"\nresult:\t\t{Math.Cosh(Function.GetNumber())}\n", ConsoleColor.Green);
                    }

                    //tanh
                    else if (menuChoice == 13)
                    {
                        Print.Text("\thyperbolic tangent of an angle\n\n", ConsoleColor.Cyan);
                        Print.Text($"\nresult:\t\t{Math.Tanh(Function.GetNumber())}\n", ConsoleColor.Green);
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
    }
}
