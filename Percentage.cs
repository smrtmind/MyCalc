using System;

namespace MyCalc
{
    public class Percentage
    {
        private static double number1;
        private static double number2;
        private static double result;

        public static void Use(byte menuChoice)
        {
            switch (menuChoice)
            {
                case 1:
                    Print.Text("\twhat is ... % of number ...\n\n", ConsoleColor.Cyan, consoleClear: true);
                    number1 = Number.Get("percent:\t");
                    number2 = Number.Get();
                    result = (number1 / 100) * number2;
                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                    break;

                case 2:
                    Print.Text("\twhat % is number ... of number ...\n\n", ConsoleColor.Cyan, consoleClear: true);
                    number1 = Number.Get();
                    number2 = Number.Get();
                    result = 100 / (number2 / number1);
                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                    break;

                case 3:
                    Print.Text("\tadd ... % to the number ...\n\n", ConsoleColor.Cyan, consoleClear: true);
                    number1 = Number.Get("percent:\t");
                    number2 = Number.Get();
                    result = ((number2 / 100) * number1) + number2;
                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                    break;

                case 4:
                    Print.Text("\tsubtract ... % from the number ...\n\n", ConsoleColor.Cyan, consoleClear: true);
                    number1 = Number.Get("percent:\t");
                    number2 = Number.Get();
                    result = number2 - ((number2 / 100) * number1);
                    Print.Text($"\nresult:\t\t{Math.Round(result, 2)}\n", ConsoleColor.Green);
                    break;
            }
        }
    }
}
