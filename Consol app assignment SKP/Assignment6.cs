using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_app_assignment_SKP
{
    internal class Assignment6
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

        private static void ValidateEmailAddress()
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
                    if (email.Length > 4)
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
        private static bool Validate(string email)
        {
            while (true)
            {
                if (email == null || !HasAtAndDot(email))
                {
                    throw new InvalidEmailAddressException("No @ or .");
                }

                string[] parts = email.Split('@');
                if (parts.Length != 2 || parts[0].Length < 1 || parts[1].Length < 5)
                {
                    throw new InvalidEmailAddressException("Local or Host too short");
                }

                if (!IsEmailDigits(parts[1]))
                {

                }
                else if (!IsDomainIP(parts[1]))
                {
                    throw new InvalidEmailAddressException("Invalid IP address as Host");
                }

                int lastDotIndex = parts[1].LastIndexOf('.');
                if (lastDotIndex == -1)
                {
                    throw new InvalidEmailAddressException("No . in Domain");
                }

                string hostName = parts[1].Substring(0, lastDotIndex);
                string topLevelDomain = parts[1].Substring(lastDotIndex + 1);

                if (hostName.Length < 2 || topLevelDomain.Length < 2 || topLevelDomain.Length > 4)
                {
                    throw new InvalidEmailAddressException("Host name too short or TLD length error");
                }

                if (!ValidEmailCharacters(email))
                {

                    throw new InvalidEmailAddressException("Email contains invalid characters");
                }

                return true;
            }
        }
        private static bool HasAtAndDot(string email)
        {
            int atIndex = email.IndexOf('@');
            return atIndex != -1 && email.LastIndexOf('@') == atIndex && email.Contains('.');
        }

        private static bool ValidEmailCharacters(string email)
        {
            foreach (char ch in email)
            {
                if (!(char.IsLetterOrDigit(ch) || ch == '@' || ch == '.' || ch == '-' || ch == '_'))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsEmailDigits(string parts1)
        {
            foreach (char ch in parts1)
            {
                if (!char.IsDigit(ch) && ch != '.')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsDomainIP(string parts1)
        {
            string[] octets = parts1.Split('.');

            if (octets.Length != 4)
            {
                return false;
            }

            foreach (string octet in octets)
                if (!int.TryParse(octet, out int value) || value < 0 || value > 255)
                {
                    return false;
                }

            return true;
        }

        private class InvalidEmailAddressException(string message) : Exception(message);
    }
}
