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

                    if (input == "<") break;

                    switch (menuChoice)
                    {
                        //calculator
                        case 1:
                            Calculator.Use();
                            break;

                        //square
                        case 2:
                            Print.Text("\tsquare of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), 2)}\n", ConsoleColor.Green);
                            break;

                        //cube
                        case 3:
                            Print.Text("\tcube of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), 3)}\n", ConsoleColor.Green);
                            break;

                        //number to a power
                        case 4:
                            Print.Text("\traise a number to a power\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), Number.Get("power:\t\t"))}\n", ConsoleColor.Green);
                            break;

                        //square root
                        case 5:
                            Print.Text("\tsquare root of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Sqrt(Number.Get())}\n", ConsoleColor.Green);
                            break;

                        //cube root
                        case 6:
                            Print.Text("\tcube root of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Cbrt(Number.Get())}\n", ConsoleColor.Green);
                            break;

                        //root to a power
                        case 7:
                            Print.Text("\tN root of a number\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Pow(Number.Get(), 1 / Number.Get("power:\t\t"))}\n", ConsoleColor.Green);
                            break;

                        //sine
                        case 8:
                            Print.Text("\tsine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Sin((Number.Get()) * Math.PI / 180)}\n", ConsoleColor.Green);
                            break;

                        //cosine
                        case 9:
                            Print.Text("\tcosine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Cos((Number.Get()) * Math.PI / 180)}\n", ConsoleColor.Green);
                            break;

                        //tangent
                        case 10:
                            Print.Text("\ttangent of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Tan((Number.Get()) * Math.PI / 180)}\n", ConsoleColor.Green);
                            break;

                        //sinh
                        case 11:
                            Print.Text("\thyperbolic sine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Sinh(Number.Get())}\n", ConsoleColor.Green);
                            break;

                        //cosh
                        case 12:
                            Print.Text("\thyperbolic cosine of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Cosh(Number.Get())}\n", ConsoleColor.Green);
                            break;

                        //tanh
                        case 13:
                            Print.Text("\thyperbolic tangent of an angle\n\n", ConsoleColor.Cyan, consoleClear: true);
                            Print.Text($"\nresult:\t\t{Math.Tanh(Number.Get())}\n", ConsoleColor.Green);
                            break;

                        //percentage
                        case 14:
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
                            break;
                    }     
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
