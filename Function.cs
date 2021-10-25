using System;

namespace MyCalc
{
    public class Function
    {
        public static double GetNumber()
        {
            string keyboardInput = string.Empty;
            double number;
            bool numberIsFound;

            do
            {
                Print.Text("input:\t\t");
                keyboardInput = Console.ReadLine();
                numberIsFound = double.TryParse(keyboardInput, out number);

                if (number == 0)
                {
                    if (!numberIsFound) ClearLine();
                    else
                    {
                        ClearLine();
                        numberIsFound = false;
                    }
                }
            }
            while (!numberIsFound);

            return number;
        }

        private static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public static void PrintTitle(string title)
        {
            Console.Clear();
            Print.Text(title, ConsoleColor.Cyan);
        }
    }
}
