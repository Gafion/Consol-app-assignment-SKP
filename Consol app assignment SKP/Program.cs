// See https://aka.ms/new-console-template for more information
using Consol_app_assignment_SKP;


while (true)
{
    Menu.MainMenu();

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D1:
            Console.Clear();
            Assignment1.Run();
            break;
        case ConsoleKey.D2:
            Console.Clear();
            Assignment2.Run();
            break;
        case ConsoleKey.D3:
            Console.Clear();
            Assignment3.Run();
            break;
        case ConsoleKey.D4:
            Console.Clear();
            Assignment4.Run();
            break;
        case ConsoleKey.D5:
            Console.Clear();
            Assignment5.Run();
            break;
        case ConsoleKey.D6:
            Console.Clear();
            Assignment6.Run();
            break;
        case ConsoleKey.D7:
            Console.Clear();
            Assignment7.Run();
            break;
        case ConsoleKey.Q:
            Console.Clear();
            Environment.Exit(0);
            break;
    }
}
