using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            BankAccount client = new BankAccount();
            ChekingAccount checking = new ChekingAccount();
            checking.AccoNumber();
            SavingsAccount savings = new SavingsAccount();
            savings.AccoNumber();

                Console.WriteLine("Hit Enter to Display Banking Menu");
                Console.ReadLine();

                client.DisplayMenu();
                string userchoice = Console.ReadLine();

                switch (userchoice.ToUpper())
                {
                    
                    case "2A":
                        Console.Clear();
                        checking.Amount();
                        Console.WriteLine("Checking Account Balance: $" + checking.Balance);
                        break;
                    case "2C":
                        Console.Clear();
                        savings.Amount();
                        Console.WriteLine("Savings Account Balance: $" + savings.Balance);
                        break;
                    case "3A":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        checking.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + checking.Deposit);
                        checking.DepositBalance(checking.Deposit);
                        break;
                    
                    case "3C":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        savings.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + savings.Deposit);
                        savings.DepositBalance(savings.Deposit);
                        break;
                    case "4A":
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        checking.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + checking.Withdrawal);
                        checking.WithdrawBalance(checking.Withdrawal);
                        break;
                    case "4C":
                        Console.Clear(); 
                        Console.WriteLine("How much would you like to withdraw?");
                        savings.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + savings.Withdrawal);
                        savings.WithdrawBalance(savings.Withdrawal);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("You have chosen to exit the online banking. Thanks and come again!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                  
                        break;
                }
            } 
        }
    }
}
