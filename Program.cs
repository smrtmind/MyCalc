using System;
using System.Text;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyboardInput = string.Empty;

            while (keyboardInput.ToLower() != "y")
            {
                byte menuChoice;
                double result = 0;
                double number, number1, percent, power;
                bool numberIsFound;

                do
                {
                    //print huge starting options
                    MainMenuOptions();

                    Console.ForegroundColor = ConsoleColor.Green;
                    keyboardInput = Console.ReadLine();
                    byte.TryParse(keyboardInput, out menuChoice);
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
                            Print("\tcalculator\n", ConsoleColor.Cyan, slowText: true);
                            Print("\nuse [=] to get a result or\ninterrupt the current input\n\n", ConsoleColor.Blue);

                            if (result == 0)
                            {
                                do
                                {
                                    Print("input:\t\t");
                                    keyboardInput = Console.ReadLine();
                                    numberIsFound = double.TryParse(keyboardInput, out number);

                                    if (keyboardInput == "=")
                                    {
                                        Print("\ninput interrupted\n", ConsoleColor.Blue);
                                        break;
                                    }
                                }
                                while (!numberIsFound);

                                result = number;
                            }

                            else Print($"\t\t{result}\n", ConsoleColor.Green);

                            while (keyboardInput != "=")
                            {
                                Print("+  -  *  /\t", ConsoleColor.DarkYellow);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                keyboardInput = Console.ReadLine();
                                Console.ResetColor();

                                switch (keyboardInput)
                                {
                                    case "+":
                                        do
                                        {
                                            Print("input:\t\t");
                                            keyboardInput = Console.ReadLine();
                                            numberIsFound = double.TryParse(keyboardInput, out number);

                                            if (keyboardInput == "=")
                                            {
                                                Print("\ninput interrupted\n", ConsoleColor.Blue);
                                                Print($"result:\t\t{result}\n", ConsoleColor.Green);
                                                break;
                                            }

                                            else result += number;
                                        }
                                        while (!numberIsFound);

                                        break;

                                    case "-":
                                        do
                                        {
                                            Print("input:\t\t");
                                            keyboardInput = Console.ReadLine();
                                            numberIsFound = double.TryParse(keyboardInput, out number);

                                            if (keyboardInput == "=")
                                            {
                                                Print("\ninput interrupted\n", ConsoleColor.Blue);
                                                Print($"result:\t\t{result}\n", ConsoleColor.Green);
                                                break;
                                            }

                                            else result -= number;
                                        }
                                        while (!numberIsFound);

                                        break;

                                    case "*":
                                        do
                                        {
                                            Print("input:\t\t");
                                            keyboardInput = Console.ReadLine();
                                            numberIsFound = double.TryParse(keyboardInput, out number);

                                            if (keyboardInput == "=")
                                            {
                                                Print("\ninput interrupted\n", ConsoleColor.Blue);
                                                Print($"result:\t\t{result}\n", ConsoleColor.Green);
                                                break;
                                            }

                                            else result *= number;
                                        }
                                        while (!numberIsFound);

                                        break;

                                    case "/":
                                        do
                                        {
                                            Print("input:\t\t");
                                            keyboardInput = Console.ReadLine();
                                            numberIsFound = double.TryParse(keyboardInput, out number);

                                            if (keyboardInput == "=")
                                            {
                                                Print("\ninput interrupted\n", ConsoleColor.Blue);
                                                Print($"result:\t\t{result}\n", ConsoleColor.Green);
                                                break;
                                            }

                                            else if (number == 0)
                                            {
                                                Print("division by zero is not possible\a".PadLeft(49, ' ') + "\n", ConsoleColor.Red);
                                            }

                                            else result /= number;
                                        }
                                        while (!numberIsFound || number == 0);

                                        break;

                                    case "=":
                                        Print($"\nresult:\t\t{result}\n", ConsoleColor.Green);
                                        break;

                                    default:
                                        Print("unknown operator\a".PadLeft(33, ' ') + "\n", ConsoleColor.Red);
                                        break;
                                }
                            }

                            do
                            {
                                Print("\nContinue using the calculator?");
                                Print(" [y] ", ConsoleColor.Green);
                                Print("/");
                                Print(" [n] ", ConsoleColor.Green);
                                Print(": ");

                                Console.ForegroundColor = ConsoleColor.Green;
                                keyboardInput = Console.ReadLine();
                                Console.ResetColor();

                                if (keyboardInput.ToLower() != "y" && keyboardInput.ToLower() != "n")
                                {
                                    Print("y - continue\a".PadLeft(56, ' ') + "\n", ConsoleColor.Red);
                                    Print("n - exit\a".PadLeft(52, ' '), ConsoleColor.Red);
                                    continue;
                                }
                            }
                            while (keyboardInput.ToLower() != "y" && keyboardInput.ToLower() != "n");

                            if (keyboardInput.ToLower() == "y")
                            {
                                do
                                {
                                    Print("\nSave current result as starting number?");
                                    Print(" [y] ", ConsoleColor.Green);
                                    Print("/");
                                    Print(" [n] ", ConsoleColor.Green);
                                    Print(": ");

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    keyboardInput = Console.ReadLine();
                                    Console.ResetColor();

                                    if (keyboardInput.ToLower() != "y" && keyboardInput.ToLower() != "n")
                                    {
                                        Print($"\t\t\t\t\t\t    y - start from {result}\a\n", ConsoleColor.Red);
                                        Print("n - start from 0\a".PadLeft(69, ' '), ConsoleColor.Red);
                                        continue;
                                    }
                                }
                                while (keyboardInput.ToLower() != "y" && keyboardInput.ToLower() != "n");

                                if (keyboardInput.ToLower() == "y") continue;

                                if (keyboardInput.ToLower() == "n")
                                {
                                    result = 0;
                                    continue;
                                }
                            }

                            if (keyboardInput.ToLower() == "n") break;
                        }
                    }

                    //square
                    else if (menuChoice == 2)
                    {
                        Console.Clear();
                        Print("\tsquare of a number\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Pow(number, 2)}\n", ConsoleColor.Green);
                    }

                    //cube
                    else if (menuChoice == 3)
                    {
                        Console.Clear();
                        Print("\tcube of a number\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Pow(number, 3)}\n", ConsoleColor.Green);
                    }

                    //number to a power
                    else if (menuChoice == 4)
                    {
                        Console.Clear();
                        Print("\traise a number to a power\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        power = GetNumber("power:\t\t");
                        Print($"\nresult:\t\t{Math.Pow(number, power)}\n", ConsoleColor.Green);
                    }

                    //square root
                    else if (menuChoice == 5)
                    {
                        Console.Clear();
                        Print("\tsquare root of a number\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Sqrt(number)}\n", ConsoleColor.Green);
                    }

                    //cube root
                    else if (menuChoice == 6)
                    {
                        Console.Clear();
                        Print("\tcube root of a number\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Cbrt(number)}\n", ConsoleColor.Green);
                    }

                    //percentage
                    else if (menuChoice == 7)
                    {
                        do
                        {
                            //print starting options
                            PercentageOptions();

                            Console.ForegroundColor = ConsoleColor.Green;
                            keyboardInput = Console.ReadLine();
                            byte.TryParse(keyboardInput, out menuChoice);
                            Console.ResetColor();

                            if (keyboardInput.ToLower() == "<") break;

                            switch (menuChoice)
                            {
                                case 1:
                                    Console.Clear();
                                    Print("\twhat is ... % of number ...\n\n", ConsoleColor.Cyan, slowText: true);
                                    percent = GetNumber("input %:\t");
                                    number = GetNumber("input number:\t");

                                    result = (number / 100) * percent;
                                    Print($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Print("\twhat % is number ... of number ...\n\n", ConsoleColor.Cyan, slowText: true);
                                    number = GetNumber("input number1:\t");
                                    number1 = GetNumber("input number2:\t");

                                    result = 100 / (number1 / number);
                                    Print($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;

                                case 3:
                                    Console.Clear();
                                    Print("\tadd ... % to the number ...\n\n", ConsoleColor.Cyan, slowText: true);
                                    percent = GetNumber("input %:\t");
                                    number = GetNumber("input number:\t");

                                    result = ((number / 100) * percent) + number;
                                    Print($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;

                                case 4:
                                    Console.Clear();
                                    Print("\tsubtract ... % from the number ...\n\n", ConsoleColor.Cyan, slowText: true);
                                    percent = GetNumber("input %:\t");
                                    number = GetNumber("input number:\t");

                                    result = number - ((number / 100) * percent);
                                    Print($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                                    break;
                            }
                        }
                        while (menuChoice <= 0 || menuChoice > 4);
                    }

                    //sine
                    else if (menuChoice == 8)
                    {
                        Console.Clear();
                        Print("\tsine of an angle\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Sin((number) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //cosine
                    else if (menuChoice == 9)
                    {
                        Console.Clear();
                        Print("\tcosine of an angle\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Cos((number) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //tangent
                    else if (menuChoice == 10)
                    {
                        Console.Clear();
                        Print("\ttangent of an angle\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Tan((number) * Math.PI / 180)}\n", ConsoleColor.Green);
                    }

                    //sinh
                    else if (menuChoice == 11)
                    {
                        Console.Clear();
                        Print("\thyperbolic sine of an angle\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Sinh(number)}\n", ConsoleColor.Green);
                    }

                    //cosh
                    else if (menuChoice == 12)
                    {
                        Console.Clear();
                        Print("\thyperbolic cosine of an angle\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Cosh(number)}\n", ConsoleColor.Green);
                    }

                    //tanh
                    else if (menuChoice == 13)
                    {
                        Console.Clear();
                        Print("\thyperbolic tangent of an angle\n\n", ConsoleColor.Cyan, slowText: true);
                        number = GetNumber("input:\t\t");
                        Print($"\nresult:\t\t{Math.Tanh(number)}\n", ConsoleColor.Green);
                    }

                    else if (keyboardInput.ToLower() == "<") break;
                }
                while (menuChoice <= 0 || menuChoice > 13);
                
                //stop the program and exit
                if (keyboardInput.ToLower() == "<")
                {
                    //print the animation
                    ProgramShutDown();
                    break;
                }

                do
                {
                    Print("\nExit the program?");
                    Print(" [y] ", ConsoleColor.Green);
                    Print("/");
                    Print(" [n] ", ConsoleColor.Green);
                    Print(": ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    keyboardInput = Console.ReadLine();
                    Console.ResetColor();

                    if (keyboardInput.ToLower() != "y" && keyboardInput.ToLower() != "n")
                    {
                        Print("y - exit\a".PadLeft(39, ' ') + "\n", ConsoleColor.Red);
                        Print("n - return to main menu\a".PadLeft(54, ' '), ConsoleColor.Red);
                        continue;
                    }
                }
                while (keyboardInput.ToLower() != "y" && keyboardInput.ToLower() != "n");

                if (keyboardInput.ToLower() == "y") ProgramShutDown();
            }
        }
        internal static void MainMenuOptions()
        {
            Console.Clear();

            Print("MyCalc v1.0 final\n\n", ConsoleColor.Cyan);
            Print("choose the type of operation:", ConsoleColor.Green);

            Print("[<]".PadLeft(22, ' '), ConsoleColor.Green);
            Print($"  exit\n\n");

            Print("[1]".PadLeft(19, ' '), ConsoleColor.Green);
            Print($"  calculator\n\n");

            Print("[2]".PadLeft(19, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Print("  x\u00B2");

            Print("[3]".PadLeft(12, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Print("  x\u00B3");

            Print("[4]".PadLeft(12, ' '), ConsoleColor.Green);
            Print($"  xʸ\n\n");

            Print("[5]".PadLeft(19, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Print("  \u00B2√");

            Print("[6]".PadLeft(12, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Print("  \u00B3√");

            Print("[7]".PadLeft(12, ' '), ConsoleColor.Green);
            Print("  %");
            Print(" >>>\n\n", ConsoleColor.Green);

            Print("[8]".PadLeft(19, ' '), ConsoleColor.Green);
            Print("  sin");

            Print("[9]".PadLeft(11, ' '), ConsoleColor.Green);
            Print("  cos");

            Print("[10]".PadLeft(12, ' '), ConsoleColor.Green);
            Print($" tan\n\n");

            Print("[11]".PadLeft(20, ' '), ConsoleColor.Green);
            Print(" sinh");

            Print("[12]".PadLeft(11, ' '), ConsoleColor.Green);
            Print(" cosh");

            Print("[13]".PadLeft(11, ' '), ConsoleColor.Green);
            Print(" tanh");

            Print("\n\n\t\tmake your choice: ");
        }
        internal static void PercentageOptions()
        {
            Console.Clear();

            Print("interest operations\n\n", ConsoleColor.Cyan);
            Print("choose the type of operation:\n\n", ConsoleColor.Green);

            Print("[1]".PadLeft(19, ' '), ConsoleColor.Green);
            Print(" what is ... % of number ...\n");
            Print("[2]".PadLeft(19, ' '), ConsoleColor.Green);
            Print(" what % is number1 ... of number2 ...\n");
            Print("[3]".PadLeft(19, ' '), ConsoleColor.Green);
            Print(" add ... % to the number ...\n");
            Print("[4]".PadLeft(19, ' '), ConsoleColor.Green);
            Print(" subtract ... % from the number ...\n\n");

            Print("[<]".PadLeft(19, ' '), ConsoleColor.Green);
            Print(" return to main menu");

            Print("\n\n\t\tmake your choice: ");
        }
        internal static void ProgramShutDown()
        {
            Console.Clear();
            Print($"Exiting...\n\n");

            //make slow print
            for (int i = 0; i < Console.WindowWidth - 5; i++)
            {
                Print("|", ConsoleColor.Green);
                Thread.Sleep(1);
            }

            Console.Clear();

            Print($@"|_      _ _ _  __|_ _ _ . _  _|" + "\n", ConsoleColor.Cyan);
            Print($@"|_)\/  _\| | ||  | | | ||| |(_|" + "\n", ConsoleColor.Cyan);
            Print($@"   /                           " + "\n", ConsoleColor.Cyan);

            Print($"https://github.com/smrtmind \n");
            Thread.Sleep(1000);
        }
        internal static double GetNumber(string text)
        {
            string keyboardInput = string.Empty;
            double number;
            bool numberFound;

            do
            {
                Print(text);
                keyboardInput = Console.ReadLine();
                numberFound = double.TryParse(keyboardInput, out number);
            }
            while (!numberFound);

            return number;
        }
        internal static void Print(string text, ConsoleColor color = ConsoleColor.White, bool slowText = false)
        {
            if (slowText)
            {
                char[] letters = text.ToCharArray();

                Console.ForegroundColor = color;

                foreach (char element in letters)
                {
                    Console.Write(element);
                    Thread.Sleep(5);
                }

                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ResetColor();
            }
        }
    }
}
