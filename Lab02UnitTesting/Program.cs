using System;

namespace Lab02UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Withdraw Funds");
            Console.WriteLine("2) Deposit Funds");
            Console.WriteLine("3) Check Balance");
            Console.WriteLine("4) Exit");
            string choice = Console.ReadLine();
            MenuNav(choice);
            return choice;
        }
        static void MenuNav(string choice)
        {
            if (choice == "1")
            {
                Withdraw();
            } else if (choice == "2")
            {
                Deposit();
            }
        }
        static void Withdraw()
        {

        }
    }
}
