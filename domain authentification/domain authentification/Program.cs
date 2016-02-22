using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_authentification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = "";

            ConsoleKeyInfo key;

            do
            {
                //Password masking:
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);

            Console.Write("\n");

            authentification a = new authentification();

            if (a.validate_credentials(username, password))
            {
                Console.WriteLine("Credentials are correct");
            }
            else
            {
                Console.WriteLine("Credentials are wrong");
            }

            //Console.WriteLine(a.validate_credentials(username, password));

            Console.ReadKey();
        }
    }
}
