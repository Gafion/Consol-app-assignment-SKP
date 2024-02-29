using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Consol_app_assignment_SKP
{
    internal class Assignment5
    {
        static internal void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Menu.Ass5Menu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Q:
                        backToMenu = true;
                        break;
                    case ConsoleKey.Enter:
                        JsonEditor();
                        break;
                    default:
                        break;
                }
            }

        }

        static void JsonEditor()
        {
            StringBuilder sInput = new StringBuilder("{ \" ");

            bool isValidated = false;
            while (!isValidated)
            {
                Menu.JsonEditor();
                Console.Write(sInput.ToString());

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    try
                    {
                        string jsonString = sInput.ToString().TrimEnd(',', ' ') + " \" }";
                        JsonDocument jText = JsonDocument.Parse(jsonString);
                        Console.Write($"{jsonString} is valid.\n\nPress Enter to go back");
                        Console.ReadKey();
                        isValidated = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message}\n\nPress Enter to continue");
                        Console.ReadKey();
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Backspace)
                {
                    if (sInput.Length > 4)
                    {
                        sInput.Remove(sInput.Length - 1, 1);
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    
                    if (pressedKey.Key == ConsoleKey.Tab)
                    {
                        sInput.Append(" \" : \" ");
                    }
                    else if (pressedKey.Key == ConsoleKey.OemComma)
                    {
                        sInput.Append(" \" , \" ");
                    }
                    else
                    {
                        sInput.Append(pressedKey.KeyChar);
                    }
                }

            }
        }
    }
}