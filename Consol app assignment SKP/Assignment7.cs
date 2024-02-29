using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Consol_app_assignment_SKP
{
    internal class Assignment7
    {
        public static void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Menu.Ass6Menu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Q:
                        backToMenu = true;
                        break;
                    case ConsoleKey.Enter:
                        ValidateEmailAddress();
                        break;
                    default:
                        break;
                }
            }
        }

        static void ValidateEmailAddress()
        {
            StringBuilder email = new StringBuilder("");

            bool isValidated = false;
            while (!isValidated)
            {
                Menu.Ass6Menu();
                Console.Write("Please enter an email to validate: ");
                Console.Write(email.ToString());

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    try
                    {
                        string emailValidation = email.ToString().TrimEnd(',', ' ');
                        Validate(emailValidation);
                        Console.WriteLine($"\n\nThe email: {email} is valid");
                        Console.WriteLine("\nPress Enter to return");
                        Console.ReadKey();
                        isValidated = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n\nThe email: {email} is not valid. \nReason: {ex.Message}");
                        Console.WriteLine("\nPress Enter to return");
                        Console.ReadKey();
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Backspace)
                {
                    if (email.Length > 0)
                    {
                        email.Remove(email.Length - 1, 1);
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
                        email.Append(" \" : \" ");
                    }
                    else if (pressedKey.Key == ConsoleKey.OemComma)
                    {
                        email.Append(" \" , \" ");
                    }
                    else
                    {
                        email.Append(pressedKey.KeyChar);
                    }
                }

            }
        }
        static bool Validate(string email)
        {
            var standardEmailPattern = new Regex(@"^[\w.%+-]+@(?![\d.]+$)(?:[\w-]+\.)+[\w]{2,}$");
            var ipEmailPattern = new Regex(@"^[\w.%+-]+@(?!25[6-9]|2[6-9][0-9]|1\d{3}|[2-9]\d{2}|\d{4})(\d{1,3}\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");

            if (!standardEmailPattern.IsMatch(email))
            {
                if (!ipEmailPattern.IsMatch(email))
                {
                    throw new InvalidEmailAddressException("Invalid email format");
                }
            }

            return true;
        }

        private class InvalidEmailAddressException(string message) : Exception(message);
    }
}
