using System;

namespace Lab02UnitTesting
{
    class Program
    {
        public static double balance = 1000;
        public static double totWithdraw = 0;
        public static double totDeposit = 0;

        static void Main(string[] args)
        {
            
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            MainMenu();
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Withdraw Funds");
            Console.WriteLine("2) Deposit Funds");
            Console.WriteLine("3) Check Balance");
            Console.WriteLine("4) Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Withdraw();
                return true;
            }
            else if (choice == "2")
            {
                Deposit();
                return true;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Your account balance is ${0}.", balance);
                return true;
            } else if (choice == "4")
            {
                return false;
            } else
            {
                Console.WriteLine("That is not an available option.");
                Console.ReadLine();
                return true;
            }
        }
        static void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw from your funds.");
            string inputmoney = Console.ReadLine();
            double amount = Convert.ToInt32(inputmoney);
            if (balance >= amount)
            {
                balance = balance - amount;
                totWithdraw = totWithdraw + amount;
                if (totWithdraw != amount)
                {
                    Console.WriteLine("You have withdrawn ${0} this transaction and ${1) this session.  Your new balance is ${2}.", amount, totWithdraw, balance);
                    Console.ReadLine();
                    MainMenu();
                }
                else if (balance == amount)
                {
                    balance = balance - amount;
                    totWithdraw = totWithdraw + amount;
                    Console.WriteLine("You have withdrawn ${0} this transaction.  Your new balance is ${1}", amount, balance);
                    Console.ReadLine();
                    MainMenu();
                }
            }
            else
            {
                Console.WriteLine("I'm sorry, that amount is not allowed");
                Console.ReadLine();
                MainMenu();
            }
        }
        static void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit to your funds.");
            string inputmoney = Console.ReadLine();
            double amount = Convert.ToInt32(inputmoney);
            balance = balance + amount;
            totDeposit = totDeposit + amount;
            if (totDeposit == amount)
            {
                Console.WriteLine("You have deposited ${0} this transaction.  Your new balance is ${1}", amount, balance);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("You have depositied ${0} this transaction and ${1} this session.  Your new balance is ${2}.", amount, totDeposit, balance);
                Console.ReadLine();
            }
        }

    }
}
