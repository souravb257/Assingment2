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
          
            BankAccount bank = new BankAccount();
            ChekingAccount checking = new ChekingAccount();
            checking.AccoNumber();
            SavingsAccount savings = new SavingsAccount();
            savings.AccoNumber();

                Console.WriteLine("Hit Enter to Display Banking Menu");
                Console.ReadLine();

                bank.DisplayMenu();
                string userchoice = Console.ReadLine();
            } 
        }
    }
}
