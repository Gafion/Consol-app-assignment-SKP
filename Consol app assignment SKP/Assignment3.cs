using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Consol_app_assignment_SKP
{
    internal class Assignment3
    {
        private static int width = Console.WindowWidth;
        public static void Run()
        {

            Menu.Ass3Menu();

            bool backToMenu = false;
            while (!backToMenu)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Q)
                {
                    backToMenu = true;
                }
            }            
        }

        public static void Calculator(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Menu.DrawTextLine(width, $"Calculating factorial of {n}");
            Menu.DrawTextLine(width, $"Result = {factorial}");
        }
    }
}
