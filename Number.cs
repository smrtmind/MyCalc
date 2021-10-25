using System;

namespace MyCalc
{
    public class Number
    {
        public static double Get(string text = "input:\t\t")
        {
            string keyboardInput = string.Empty;
            double number;
            bool numberIsFound;

            do
            {
                Print.Text($"{text}");
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
    }
}
