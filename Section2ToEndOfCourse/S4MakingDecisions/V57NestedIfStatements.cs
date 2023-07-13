using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4MakingDecisions
{
    public class V57NestedIfStatements
    {
        private string _username = String.Empty;
        private string _password = String.Empty;

        public void Lesson()
        {
            RegisterNewUser();
            Console.WriteLine("\nNew user successfully created!\n");

            Console.WriteLine("Log in using new user.\n");
            var loginSuccessful = Login();
            if (!loginSuccessful)
            {
                Console.WriteLine("\n\nLog in failed. Incorrect credentials.");
            }
            else
            {
                Console.WriteLine("\n\nSuccessfully logged in!");
            }

        }

        private void RegisterNewUser()
        {
            Console.WriteLine("Register your new user.\n");

            _username = GetUsernameForNewUser();
            _password = GetPasswordForNewUser();
        }

        private static string GetUsernameForNewUser()
        {
            Console.Write("Enter your new username: ");
            var username = Console.ReadLine();

            return username != null ? username : string.Empty;
        }

        private static string GetPasswordForNewUser()
        {
            Console.Write("Enter your new password: ");

            var passwordInput = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && passwordInput.Length > 0)
                {
                    Console.Write("\b \b");
                    passwordInput = passwordInput[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    passwordInput += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            return passwordInput != null ? passwordInput : String.Empty;
        }

        private bool Login()
        {
            var usernameInput = GetUsernameForLogin();
            var passwordInput = GetPasswordForLogin();

            return usernameInput == _username && passwordInput == _password;
        }

        private static string GetUsernameForLogin()
        {
            Console.Write("Enter your username: ");
            var usernameInput = Console.ReadLine();

            return usernameInput != null ? usernameInput : String.Empty;
        }

        private static string GetPasswordForLogin()
        {
            Console.Write("Enter your password: ");

            var passwordInput = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && passwordInput.Length > 0)
                {
                    Console.Write("\b \b");
                    passwordInput = passwordInput[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    passwordInput += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            return passwordInput != null ? passwordInput : String.Empty;
        }
    }
}
