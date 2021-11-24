using System;

namespace MyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (input != "y")
            {
                byte menuChoice;

                do
                {
                    //print huge starting options
                    Print.MainMenuOptions();

                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine().ToLower();
                    byte.TryParse(input, out menuChoice);
                    Console.ResetColor();

                    //calculator
                    if (menuChoice == 1) Calculator.Use();

                    //square
                    else if (menuChoice == 2)
                    {
                        Print.Text("\tsquare of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), 2)}\n", ConsoleColor.Green);
                    }

                    //cube
                    else if (menuChoice == 3)
                    {
                        Print.Text("\tcube of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), 3)}\n", ConsoleColor.Green);
                    }

                    //number to a power
                    else if (menuChoice == 4)
                    {
                        Print.Text("\traise a number to a power\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), Number.Get("power:\t\t"))}\n", ConsoleColor.Green);
                    }

                    //square root
                    else if (menuChoice == 5)
                    {
                        Print.Text("\tsquare root of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Sqrt(Number.Get())}\n", ConsoleColor.Green);
                    }

                    //cube root
                    else if (menuChoice == 6)
                    {
                        Print.Text("\tcube root of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Cbrt(Number.Get())}\n", ConsoleColor.Green);
                    }

                    //root to a power
                    else if (menuChoice == 7)
                    {
                        Print.Text("\tN root of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), 1 / Number.Get("power:\t\t"))}\n", ConsoleColor.Green);
                    }

                    //sine
                    else if (menuChoice == 8)
                    {
                        Print.Text("\tsine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Sin((Number.Get()) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //cosine
                    else if (menuChoice == 9)
                    {
                        Print.Text("\tcosine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Cos((Number.Get()) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //tangent
                    else if (menuChoice == 10)
                    {
                        Print.Text("\ttangent of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Tan((Number.Get()) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //sinh
                    else if (menuChoice == 11)
                    {
                        Print.Text("\thyperbolic sine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Sinh(Number.Get())}\n", ConsoleColor.Green);
                    }

                    //cosh
                    else if (menuChoice == 12)
                    {
                        Print.Text("\thyperbolic cosine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Cosh(Number.Get())}\n", ConsoleColor.Green);
                    }

                    //tanh
                    else if (menuChoice == 13)
                    {
                        Print.Text("\thyperbolic tangent of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                        Print.Text($"\nresult:\t\t{Math.Tanh(Number.Get())}\n", ConsoleColor.Green);
                    }

                    //percentage
                    else if (menuChoice == 14)
                    {
                        do
                        {
                            //print starting options
                            Print.PercentageOptions();

                            Console.ForegroundColor = ConsoleColor.Green;
                            input = Console.ReadLine().ToLower();
                            byte.TryParse(input, out menuChoice);
                            Console.ResetColor();

                            if (input == "<") break;
                            else Percentage.Use(menuChoice);
                        }
                        while (menuChoice <= 0 || menuChoice > 4);
                    }

                    else if (input == "<") break;
                }
                while (menuChoice <= 0 || menuChoice > 14);
                
                //stop the program and exit
                if (input == "<")
                {
                    //print the animation
                    Print.ProgramShutDown();
                    break;
                }

                do
                {
                    Print.Question("\nExit the program?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine().ToLower();
                    Console.ResetColor();

                    if (input != "y" && input != "n")
                    {
                        Print.Text("y - exit\a".PadLeft(39, ' ') + "\n", ConsoleColor.Red);
                        Print.Text("n - return to main menu\a".PadLeft(54, ' '), ConsoleColor.Red);
                        continue;
                    }
                }
                while (input != "y" && input != "n");

                if (input == "y") Print.ProgramShutDown();
            }
        }      
    }
}
