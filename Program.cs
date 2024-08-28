#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Welcome();
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome! Please enter your username and password.");
        
        Console.Write("Username: ");

        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = ReadPassword();
        
        Console.WriteLine($"\nThank you, {username}! You are now logged in.");
    }

    // This method hides the password input by replacing characters with '*'
    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, (password.Length - 1));
                Console.Write("\b \b");
            }
        } while (key.Key != ConsoleKey.Enter);

        return password;
    }
}
