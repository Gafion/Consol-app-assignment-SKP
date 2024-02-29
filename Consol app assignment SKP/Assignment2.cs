using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_app_assignment_SKP
{
    internal class Assignment2
    {
        static int width = Console.WindowWidth;
        public static void Run()
        {
            Menu.Ass2Menu();

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

        public static void Calculator(int num1, int num2)
        {
            int sum = 0;
            for (int i = 0; i < num2; i++)
            {
                sum += num1;
            }
            Menu.DrawTextLine(width, $"Summing {num1} with {num2}");
            Menu.DrawTextLine(width, $"Result = {sum}");
        }
    }
}
