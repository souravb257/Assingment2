using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment2
{
    class ChekingAccount:BankAccount
    {
       

        private double minBalance;
        private double maxBalance;
        private double balance;
        private string accountType;



        public double MinBalance
        { get { return this.minBalance; } }

        public double MaxBalance
        { get { return this.maxBalance; } }




        public void Checking(double balance)
        {
            this.minBalance = 500;
            this.maxBalance = 1000000000000;
            this.balance = balance;
            accountType = "Checking Account";
        }
    }
}
