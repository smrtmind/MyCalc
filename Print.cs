using System;
using System.Text;
using System.Threading;

namespace MyCalc
{
    public class Print
    {
        public static void MainMenuOptions()
        {
            Console.Clear();

            Text("MyCalc v1.0 final\n\n", ConsoleColor.Cyan);
            Text("choose the type of operation:", ConsoleColor.Green);

            Text("[<]".PadLeft(22, ' '), ConsoleColor.Green);
            Text($"  exit\n\n");

            Text("[1]".PadLeft(19, ' '), ConsoleColor.Green);
            Text($"  calculator\n\n");

            Text("[2]".PadLeft(19, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Text("  x\u00B2");

            Text("[3]".PadLeft(12, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Text("  x\u00B3");

            Text("[4]".PadLeft(12, ' '), ConsoleColor.Green);
            Text($"  xʸ\n\n");

            Text("[5]".PadLeft(19, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Text("  \u00B2√x");

            Text("[6]".PadLeft(11, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Text("  \u00B3√x");

            Text("[7]".PadLeft(11, ' '), ConsoleColor.Green);
            Console.OutputEncoding = Encoding.GetEncoding(65001);
            Text("  ʸ√x\n\n");

            Text("[8]".PadLeft(19, ' '), ConsoleColor.Green);
            Text("  sin");

            Text("[9]".PadLeft(11, ' '), ConsoleColor.Green);
            Text("  cos");

            Text("[10]".PadLeft(12, ' '), ConsoleColor.Green);
            Text($" tan\n\n");

            Text("[11]".PadLeft(20, ' '), ConsoleColor.Green);
            Text(" sinh");

            Text("[12]".PadLeft(11, ' '), ConsoleColor.Green);
            Text(" cosh");

            Text("[13]".PadLeft(11, ' '), ConsoleColor.Green);
            Text(" tanh\n\n");

            Text("[14]".PadLeft(20, ' '), ConsoleColor.Green);
            Text(" %");
            Text(" >>>\n\n", ConsoleColor.Green);

            Text("\t\tmake your choice: ");
        }

        public static void PercentageOptions()
        {
            Console.Clear();

            Text("Percentage operations\n\n", ConsoleColor.Cyan);
            Text("choose the type of operation:\n\n", ConsoleColor.Green);

            Text("[1]".PadLeft(19, ' '), ConsoleColor.Green);
            Text(" what is ... % of number ...\n");
            Text("[2]".PadLeft(19, ' '), ConsoleColor.Green);
            Text(" what % is number1 ... of number2 ...\n");
            Text("[3]".PadLeft(19, ' '), ConsoleColor.Green);
            Text(" add ... % to the number ...\n");
            Text("[4]".PadLeft(19, ' '), ConsoleColor.Green);
            Text(" subtract ... % from the number ...\n\n");

            Text("[<]".PadLeft(19, ' '), ConsoleColor.Green);
            Text(" return to main menu");

            Text("\n\n\t\tmake your choice: ");
        }

        public static void ProgramShutDown()
        {
            Console.Clear();
            Text($"Exiting...\n\n");

            //make slow print
            for (int i = 0; i < Console.WindowWidth - 5; i++)
            {
                Text("|", ConsoleColor.Green);
                Thread.Sleep(1);
            }

            Console.Clear();

            Text($@"|_      _ _ _  __|_ _ _ . _  _|" + "\n", ConsoleColor.Cyan);
            Text($@"|_)\/  _\| | ||  | | | ||| |(_|" + "\n", ConsoleColor.Cyan);
            Text($@"   /                           " + "\n", ConsoleColor.Cyan);

            Text($"https://github.com/smrtmind \n");
            Thread.Sleep(1000);
        }

        public static void Text(string text, ConsoleColor color = ConsoleColor.White, bool consoleClear = false)
        {
            if (consoleClear) Console.Clear();

            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
