using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_app_assignment_SKP
{
    internal class Assignment4
    {
        private static string myPath = @"C:\Users\zbc23chco";
        public static void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Menu.Ass4Menu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Q:
                        backToMenu = true;
                        break;
                    case ConsoleKey.D1:
                        CreateOption();
                        break;
                    case ConsoleKey.D2:
                        AppendOption();
                        break;
                    case ConsoleKey.D3:
                        WriteOption();
                        break;
                    default:
                        break;
                }
            }
        }

        static void CreateOption()
        {
            Menu.Ass4Menu();

            Console.Write("Enter filename: ");
            string fileName = Console.ReadLine() ?? "";

            if (File.Exists(Path.Combine(myPath, $@"{fileName}.txt")))
            {
                Console.WriteLine("The specified file already exists.");
                Console.WriteLine("Press Q to go back.");
                goto WaitForQkeyPress;
            }

            Console.Write("Enter content: ");
            string content = Console.ReadLine() ?? "";

            SaveFile(fileName, content);

        WaitForQkeyPress:
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

        static void SaveFile(string fileName, string content)
        {
            string fullFilePath = Path.Combine(myPath, $@"{fileName}.txt");
            try
            {
                File.WriteAllText(fullFilePath, content);
                Console.WriteLine($"Successfully created '{Path.GetFileName(fullFilePath)}'!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
            }
            Console.WriteLine("Press Q to go back.");
        }

        static void AppendOption()
        {
            Menu.Ass4Menu();

            Console.Write("Enter filename: ");
            string fileName = Console.ReadLine() ?? "Placeholder";

            if (!File.Exists(Path.Combine(myPath, $@"{fileName}.txt")))
            {
                Console.WriteLine("The specified file doesn't exists.");
                Console.WriteLine("Press Q to go back.");
                goto WaitForQkeyPress;
            }

            Console.Write("Enter content to append: ");
            string appendedContent = Console.ReadLine() ?? "";

            AppendToFile(fileName, appendedContent);

        WaitForQkeyPress:
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

        static void AppendToFile(string fileName, string appendedContent)
        {
            string fullFilePath = Path.Combine(myPath, $@"{fileName}.txt");
            try
            {
                File.AppendAllText(fullFilePath, appendedContent);
                Console.WriteLine($"Appended content successfully to '{fileName}'!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
            }
            Console.WriteLine("Press Q to go back.");
                
        }

        static void WriteOption()
        {
            Menu.Ass4Menu();

            Console.Write("Enter filename: ");
            string fileName = Console.ReadLine() ?? "";

            if (!File.Exists(Path.Combine(myPath, $@"{fileName}.txt")))
            {
                Console.WriteLine("The specified file doesn't exists.");
                Console.WriteLine("Press Q to go back.");
                goto WaitForQkeyPress;
            }

            WriteFileContent(fileName);

        WaitForQkeyPress:
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

        static void WriteFileContent(string fileName)
        {
            string fullFilePath = Path.Combine(myPath, $@"{fileName}.txt");
            try
            {
                string fileContent = File.ReadAllText(fullFilePath);
                Console.WriteLine($"\nFile Content: {fileContent}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
            }

            Console.WriteLine("Press Q to go back.");
        }
    }
}
