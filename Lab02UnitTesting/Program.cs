using System;

namespace Lab02UnitTesting
{
    public class Program
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
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please 'Enter' one of the following options.");
            Console.WriteLine("1) Withdraw Funds"); //to execute withdrawl
            Console.WriteLine("2) Deposit Funds");  //to execute deposit
            Console.WriteLine("3) Check Balance");  //to check balance
            Console.WriteLine("4) Exit");
            string choice = Console.ReadLine();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            if (choice == "1")
            {
                Withdrawl();
                return true;
            }
            else if (choice == "2")
            {
                Deposit();
                return true;
            }
            else if (choice == "3")
            {
                Console.WriteLine($"Your account balance is ${balance}.");
                Continue();
                return true;
            } else if (choice == "4")
            {
                Console.WriteLine($"You have Withdrawn ${totWithdraw}.");
                Console.WriteLine($"You have Deposited ${totDeposit}");
                Console.WriteLine($"Your current Balance is ${balance}");
                Continue();
                return false;
            } else
            {
                Console.WriteLine("That is not an available option.");
                Continue();
                return true;
            }
        }
        static void Withdrawl() // most commands moved to RemoveFunds to allow for testing
        {
            Console.WriteLine("Please enter the amount you wish to withdraw from your funds: $");
            string inputmoney = Console.ReadLine();
            double amount = Convert.ToInt32(inputmoney);
            RemoveFunds(amount);
        }
        public static double RemoveFunds(double amount) //Executes the Withdrawl
        {

            try
            {
                if (balance <= amount) //If the amount requested to withdraw is more than they have
                {
                    Console.WriteLine("That Amount is not allowed.");
                    Continue();
                    return 0;
                }
                else if (amount < 0) //If they try to withdraw a negative number
                {
                    Console.WriteLine("Silly, you can't cheat by Withdrawing a negative amount");
                    Continue();
                    return 0;
                }
                else if (totWithdraw == 0) //withdraws properly using first withdrawal message to user
                {
                    balance = balance - amount;
                    totWithdraw = totWithdraw + amount;
                    Console.WriteLine($"You have withdrawn ${amount} this transaction.  Your new balance is ${balance}");
                    Continue();
                    return amount;
                }
                else if (totWithdraw != 0) //use this every time after the first withdrawal
                {
                    balance = balance - amount;
                    totWithdraw = totWithdraw + amount;
                    Console.WriteLine($"You have withdrawn ${amount} this transaction and ${totWithdraw} this session.  Your new balance is ${balance}.");
                    Continue();
                    return amount;
                }
                else //catch all
                {
                    Console.WriteLine("I'm sorry, that amount is not allowed");
                    Continue();
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // Output error message if Exception occures
                throw;
            }
            finally
            {

            }

        }
        static void Deposit() //Most instructions moved to AddFunds to allow for testing
        {
            Console.Write("Please enter the amount you wish to deposit to your funds: $");
            string inputmoney = Console.ReadLine();
            double amount = Convert.ToInt32(inputmoney);
            AddFunds(amount);
        }
        public static double AddFunds(double amount) //most of the instructions are executed here
        {
            try
            {


                if (amount < 0) //stops user from depositing a negative amount
                {
                    Console.WriteLine("Silly, you can't deposit a negative amount.");
                    Continue();
                    return 0;
                }
                else if (totDeposit == 0) //this is ran the first acceptable deposit of the session
                {
                    balance = balance + amount;
                    totDeposit = totDeposit + amount;
                    Console.WriteLine($"You have deposited ${amount} this transaction.  Your new balance is ${balance}");
                    Continue();
                    return amount;
                }
                else if (totDeposit != 0)
                {
                    balance = balance + amount;
                    totDeposit = totDeposit + amount;
                    Console.WriteLine($"You have depositied ${amount} this transaction and ${totDeposit} this session.  Your new balance is ${balance}.");
                    Continue();
                    return amount;
                }
                else
                {
                    Console.WriteLine("Sorry, you have entered an amount that is not allowed.");
                    Continue();
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Continue();
                throw;
            }
            finally
            {

            }

        }
        static void Continue()
        {
            Console.WriteLine("Please press 'Enter' to continue.");
            Console.ReadLine();
        }
    }
}
