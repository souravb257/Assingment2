using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment2
{
    class SavingsAccount:BankAccount
    {
       
        private int interestSavings;
        private int minBalance;
        private int timesOfWithdrawn;
        private double balance;
        private string accountType;

       
        public int Interest
        {
            get { return this.interestSavings; }
        }
        private int TimesWithdrawn
        {
            get { return this.timesOfWithdrawn; }
        }
       
        public void Savings(double balance)
        {
            interestSavings = 10;
            this.balance = balance;
            accountType = "Savings Account";

        }
    }
}
