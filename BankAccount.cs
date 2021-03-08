using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment2
{
    class BankAccount
    {
        private string firstName;
        private string lastName;

        private double accountNumber;
        private string accountType;

        private double balance;
        private double deposit;
        private double withdrawal;


       
        public double AccountNumber
        { get { return this.accountNumber; } }

        public string AccountType
        {
            get { return this.accountType; }
            
        }
        public double Balance
        {
            get { return this.balance; }
           
        }
        public double Deposit
        { get { return this.deposit; }
            set {this.deposit=value; }
        }

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }
      
        public BankAccount()
        {
            firstName = "Sourov";
            lastName = "Barman";
        }
        public void ChekingAccount()
        {

        }
        public void SavingsAccount()
        {

        }



        public virtual double AccoNumber()
        {
            Random rand = new Random();
            this.accountNumber = rand.Next(787878787, 45454545);
            return accountNumber;
        }
        public virtual double Amount()
        {
            balance = balance + deposit - withdrawal;
            deposit = 0;
            withdrawal = 0;
            return balance;
        }
        public virtual double DepositBalance(double input)
        {
            deposit = input;
            withdrawal = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }
        public virtual double WithdrawBalance(double input)
        {
            withdrawal = input;
            deposit = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }
        public virtual void DisplayMenu()
        {
            Console.WriteLine("Developers Bank\nWelcome to your bank account, " + firstName + " " + lastName);
            Console.WriteLine("Please choose from the options below:\n1.Open an account:\n2.Perform transactions on an account:");
            Console.WriteLine("     2A.Checking\n   2B.Savings");
            Console.WriteLine("3.Deposit Funds:\n     3A.Checking\n    3B.Savings");
            Console.WriteLine("4.Withdraw Funds:\n     4A.Checking\n   4B.Savings");
            Console.WriteLine("5.Quite");
        }
    }
}
