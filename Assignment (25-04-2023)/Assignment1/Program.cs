using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {


        static void Main(string[] args)
        {

            SavingsAccount saCust = new SavingsAccount(100001);
            CurrentAccount caCust = new CurrentAccount(100001);

            while (true)
            {

                Console.WriteLine("\n\n1. Deposit \n2. WithDraw \n3. Check Balance\n4.Exit ");
                Console.Write("Please Enter the number : ");
                int input = Convert.ToInt32(Console.ReadLine());


                if (input == 1)
                {
                    Console.WriteLine("\n1. Savings\n2. Current");
                    Console.Write("Enter Type of Account : ");
                    int type = Convert.ToInt32(Console.ReadLine());
                    if (type == 1)
                    {
                        Console.Write("Enter Amount to Deposit : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        saCust.deposit(amount);
                    }
                    else
                    {
                        Console.Write("Enter Amount to Deposit : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        caCust.deposit(amount);
                    }

                }
                if (input == 2)
                {
                    Console.WriteLine("\n1. Savings\n2. Current");
                    Console.Write("Enter Type of Account : ");
                    int type = Convert.ToInt32(Console.ReadLine());
                    if (type == 1)
                    {
                        Console.Write("Enter Amount to WithDraw : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        saCust.withDraw(amount);
                    }
                    else
                    {
                        Console.Write("Enter Amount to WithDraw : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        caCust.withDraw(amount);
                    }

                }
                if (input == 3)
                {
                    Console.WriteLine("\n1. Savings\n2. Current \n 3. Both");
                    Console.Write("Enter Type of Account : ");
                    int type = Convert.ToInt32(Console.ReadLine());
                    if (type == 1)
                    {
                        Console.WriteLine($"Your Balance in Savings Account is Rs.{saCust.checkBalance()}");
                    }
                    else if (type == 2)
                    {

                        Console.WriteLine($"Your Balance in Current Account is Rs.{caCust.checkBalance()}");
                    }

                    else
                    {
                        Console.WriteLine($"Your Total Balance in Both Accounts is Rs.{caCust.checkBalance() + saCust.checkBalance()}");
                    }
                }


            }


        }



        interface BankAccount
        {
            void deposit(double amount);
            void withDraw(double amount);
        }

        class SavingsAccount : BankAccount
        {
            double Balance = 0;
            long AcNum;

            public SavingsAccount(long AcNum)
            {
                this.AcNum = AcNum;


            }
            public void deposit(double amount)
            {

                this.Balance += amount;
                Console.WriteLine($"Amount of Rs. {amount} credited Successfully to your Account with A/C number : {this.AcNum}");
                Console.WriteLine($"Your Savings Account Balance is Rs. {this.Balance}");

            }

            public void withDraw(double amount)
            {
                if (this.Balance - amount < 0)
                    Console.WriteLine("\nInsufficient Balance\n");

                else
                {
                    this.Balance -= amount;
                    Console.WriteLine($"Amount of Rs. {amount} Debited Successfully from your Account with A/C number : {this.AcNum}");
                    Console.WriteLine($"Your Savings Account Balance is Rs. {this.Balance}");

                }
            }

            public double checkBalance()
            {
                return this.Balance;
            }
        }


        class CurrentAccount : BankAccount
        {
            double Balance = 0;
            long AcNum;
            public CurrentAccount(long AcNum)
            {
                this.AcNum = AcNum;
            }
            public void deposit(double amount)
            {
                this.Balance += amount;
                Console.WriteLine($"Amount of Rs. {amount} credited Successfully to your Account with A/C number : {this.AcNum}");
                Console.WriteLine($"Your Current Account Balance is Rs. {this.Balance}");

            }

            public void withDraw(double amount)
            {
                if (this.Balance - amount < 0)
                    Console.WriteLine("\nInsufficient Balance\n");

                else
                    this.Balance -= amount;
                    Console.WriteLine($"Amount of Rs. {amount} Debited Successfully from your Account with A/C number : {this.AcNum}");
                    Console.WriteLine($"Your Current Account Balance is Rs. {this.Balance}");
            }

            public double checkBalance()
            {
                return this.Balance;
            }
        }

    }
}


    