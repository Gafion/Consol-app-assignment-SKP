using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_app_assignment_SKP
{
    internal class Assignment1
    {
        private static int width = Console.WindowWidth;
        public static void Run()
        {
            Menu.Ass1Menu();

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
            try
            {
                int resultat = num1 * num2 / (num1 - num2) + num2;
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {resultat}");
            }
            catch (Exception e)
            {
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {e.Message}");
            }
        }

        public static void Calculator(float num1, float num2)
        {
            try
            {
                float resultat = num1 * num2 / (num1 - num2) + num2;
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {resultat}");
            }
            catch (Exception e)
            {
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {e.Message}");
            }


        }

        public static void Calculator(decimal num1, decimal num2)
        {
            try
            {
                decimal resultat = num1 * num2 / (num1 - num2) + num2;
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {resultat}");
            }
            catch (Exception e)
            {
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {e.Message}");
            }


        }

        public static void Calculator(double num1, double num2)
        {
            try
            {
                double resultat = num1 * num2 / (num1 - num2) + num2;
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {resultat}");
            }
            catch (Exception e)
            {
                Menu.DrawTextLine(width, $"{num1} * {num2} / ({num1} - {num2}) + {num2}");
                Menu.DrawTextLine(width, $" Result = {e.Message}");
            }


        }

    }
}
