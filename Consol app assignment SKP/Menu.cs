using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_app_assignment_SKP
{
    internal class Menu
    {
        public const char TOP_LEFT_CORNER = '\u250c';
        public const char TOP_RIGHT_CORNER = '\u2510';
        public const char HORIZONTAL_LINE = '\u2500';
        public const char VERTICAL_LINE = '\u2502';
        public const char VERTICAL_LINE_LEFT_END = '\u251c';
        public const char VERTICAL_LINE_RIGHT_END = '\u2524';
        public const char BOTTOM_LEFT_CORNER = '\u2514';
        public const char BOTTOM_RIGHT_CORNER = '\u2518';

        public static void MainMenu()
        {
            int width = Console.WindowWidth;

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "C# Console opgaver");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Opg. 1: Matematik");
            DrawTextLine(width, "Opg. 2: Loop med summering");
            DrawTextLine(width, "Opg. 3: Beregne fakultetet af et tal");
            DrawTextLine(width, "Opg. 4: Læs og skriv til en fil");
            DrawTextLine(width, "Opg. 5: JSON string editor og syntaks checker");
            DrawTextLine(width, "Opg. 6: Email checker - med Loop, If, regler");
            DrawTextLine(width, "Opg. 7: Email checker - regulær udtryk");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Tast et tal 1 - 7 eller Q for at afslutte");
            DrawHorizontalLinesBottom(width);
        }

        public static void Ass1Menu()
        {
            int width = Console.WindowWidth;
            const string Separator = "---------------------";

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "Matematik");
            DrawHorizontalLinesMid(width);
            Assignment1.Calculator(2, 2);
            DrawTextLine(width, Separator);
            Assignment1.Calculator(2, 4);
            DrawTextLine(width, Separator);
            Assignment1.Calculator(2f, 5f);
            DrawTextLine(width, Separator);
            Assignment1.Calculator(2f, -8.3f);
            DrawTextLine(width, Separator);
            Assignment1.Calculator(672345.23489m, 33478789.34789m);
            DrawTextLine(width, Separator);
            Assignment1.Calculator(55.88E20d, 667.89E56d);
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Q to go back");
            DrawHorizontalLinesBottom(width);
        }

        public static void Ass2Menu()
        {
            int width = Console.WindowWidth;
            const string Separator = "---------------------";

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "Loop med summering");
            DrawHorizontalLinesMid(width);
            Assignment2.Calculator(34, 67);
            DrawTextLine(width, Separator);
            Assignment2.Calculator(123, 789);
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Q to go back");
            DrawHorizontalLinesBottom(width);
        }

        public static void Ass3Menu()
        {
            int width = Console.WindowWidth;
            const string Separator = "---------------------";

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "Beregne fakultetet af et tal");
            DrawHorizontalLinesMid(width);
            Assignment3.Calculator(5);
            DrawTextLine(width, Separator);
            Assignment3.Calculator(26);
            DrawTextLine(width, Separator);
            Assignment3.Calculator(35);
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Q to go back");
            DrawHorizontalLinesBottom(width);
        }

        public static void Ass4Menu()
        {
            int width = Console.WindowWidth;

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "Læs og skriv til en fil");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "1. Create a File");
            DrawTextLine(width, "2. Append a File");
            DrawTextLine(width, "3. Write file to Console");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Q to return");
            DrawHorizontalLinesBottom(width);
        }

        public static void Ass5Menu()
        {
            int width = Console.WindowWidth;

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "JsonEditor");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Enter to start");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Q to return");
            DrawHorizontalLinesBottom(width);
        }

        public static void JsonEditor() 
        {
            int width = Console.WindowWidth;

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "JsonEditor");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Enter to validate");
            DrawTextLine(width, "Esc to restart");
            DrawHorizontalLinesBottom(width);
        }

        public static void Ass6Menu()
        {
            int width = Console.WindowWidth;

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "Email Validation");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Enter to start");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Q to return");
            DrawHorizontalLinesBottom(width);
        }

        public static void ValidateEmailAddress()
        {
            int width = Console.WindowWidth;

            Console.Clear();
            DrawHorizontalLinesTop(width);
            DrawTextLine(width, "Email Validation");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Pleae enter an email address to validate");
            DrawHorizontalLinesMid(width);
            DrawTextLine(width, "Press Esc to restart");
            DrawHorizontalLinesBottom(width);
        }

        public static void DrawHorizontalLinesTop(int width)
        {
            Console.WriteLine(TOP_LEFT_CORNER + new string(HORIZONTAL_LINE, width - 2) + TOP_RIGHT_CORNER);
        }

        public static void DrawHorizontalLinesBottom(int width)
        {
            Console.WriteLine(BOTTOM_LEFT_CORNER + new string(HORIZONTAL_LINE, width - 2) + BOTTOM_RIGHT_CORNER);
        }

        public static void DrawHorizontalLinesMid(int width)
        {
            Console.WriteLine(VERTICAL_LINE_LEFT_END + new string(HORIZONTAL_LINE, width - 2) + VERTICAL_LINE_RIGHT_END);
        }

        public static void DrawTextLine(int width, string text)
        {
            int rightPadding = width - text.Length - 3;
            Console.WriteLine(VERTICAL_LINE + new string(' ', 1) + text + new string(' ', rightPadding) + VERTICAL_LINE);
        }
    }
}
