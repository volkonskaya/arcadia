using System;

namespace Task1_Auth
{
    class Program
    {
        private static object userUsername;
        private static object userPassword;
        public static void Credentials()
        {
            Console.WriteLine("Enter a username: ");
            userUsername = Console.ReadLine();
            Console.WriteLine("Enter a password: ");
            userPassword = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your credentials");

            string username = "tania";
            string password = "12345";
            const int maxAttempt = 2;
            int attemp = 0;
            Credentials();

            if (username.Equals(userUsername) && password.Equals(userPassword))
            {
                Console.WriteLine($"Welcome {username}! Nice to see you again!");
            }
            else
            {
                while (attemp < maxAttempt)
                {
                    attemp++;
                    Console.WriteLine("Wrong username or password, please try again");
                    Credentials();
                }
                Console.WriteLine("Error! The maximum number of attempts has been exhausted!");
            }
        }
    }
}
