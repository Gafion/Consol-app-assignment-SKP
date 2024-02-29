using Consol_app_assignment_SKP;
using System.Text.Json;
using System.Text;

internal class test
{
    static void ValidateEmailAddress()
    {
        StringBuilder email = new StringBuilder("{ \" ");

        bool isValidated = false;
        while (!isValidated)
        {
            Menu.JsonEditor();
            Console.Write(email.ToString());

            ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Enter)
            {
                // validate
                try
                {
                    string emailValidation = email.ToString().TrimEnd(',', ' ') + " \" }";
                    Validate(emailValidation);
                    Console.WriteLine($"\nThe email: {email} is valid");
                    Console.WriteLine("\nPress Esc to return");
                    Console.ReadKey();
                    isValidated = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\nThe email: {email} is not valid");
                    Console.WriteLine("\nPress Esc to return");
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
    static bool Validate(string email)
    {
        while (true)
        {
            if (email == null || !HasAtAndDot(email))
            {
                return DisplayErrorMessage(email);
            }

            string[] parts = email.Split('@');
            if (parts.Length != 2 || parts[0].Length < 1 || parts[1].Length < 5)
            {
                return DisplayErrorMessage(email);
            }

            if (!IsEmailDigits(parts[1]))
            {

            }
            else if (!IsDomainIP(parts[1]))
            {
                return DisplayErrorMessage(email);
            }

            int lastDotIndex = parts[1].LastIndexOf('.');
            if (lastDotIndex == -1)
            {
                return DisplayErrorMessage(email);
            }

            string domainName = parts[1].Substring(0, lastDotIndex);
            string topLevelDomain = parts[1].Substring(lastDotIndex + 1);

            if (domainName.Length < 2 || topLevelDomain.Length < 2 || topLevelDomain.Length > 4)
            {
                return DisplayErrorMessage(email);
            }

            if (!ValidEmailCharacters(email))
            {

                return DisplayErrorMessage(email);
            }

            Console.WriteLine($"\nThe email: {email} is valid");
            Console.WriteLine("\nPress Esc to return");

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return true;
                }
            }
        }
    }
    static bool HasAtAndDot(string email)
    {
        int atIndex = email.IndexOf('@');
        return atIndex != -1 && email.LastIndexOf('@') == atIndex && email.Contains('.');
    }

    static bool ValidEmailCharacters(string email)
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

    static bool IsEmailDigits(string parts1)
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

    static bool IsDomainIP(string parts1)
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
    static bool DisplayErrorMessage(string email)
    {
        Console.WriteLine($"\nThe email: {email} is not valid");
        Console.WriteLine("\nPress Esc to return");
        while (true)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                return false;
            }
        }
    }
}