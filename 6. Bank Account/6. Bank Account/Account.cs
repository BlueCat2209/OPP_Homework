using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _6._Bank_Account
{
    class Account
    {
        // Attributes
        private long AccountNumber;
        private string Name;
        private double Balance;
        private double Rate = 0.035;

        // Methods
        public bool Deposit(double money)
        {
            if (money <= 0) return false;
            this.Balance += money;
            return true;
        }
        public bool WithDraw(double money, double fee)
        {
            if ((money <= 0) || (fee < 0)) return false;
            this.Balance += money - fee;
            return true;
        }
        public void AddInterest()
        {
            this.Balance = this.Balance + this.Balance * this.Rate;
        }
        public bool Transfer(Account transferAccount, double money)
        {
            if (transferAccount.Balance < money) return false;
            transferAccount.Balance -= money;
            this.Balance += money;
            return true;   
        }
        public void InformationToString()
        {    
            Console.WriteLine($"|{this.AccountNumber,-14}|{this.Name,-20}|{this.Balance,10:N2} VND|");
        }

        // Getter 
        public long GetAccountNumber()
        {
            return this.AccountNumber;
        }
        public double GetBalance()
        {
            return this.Balance;
        }

        // Constructors
        public Account()
        {
            this.AccountNumber = 999999;
            this.Name = "#UNDEFINED";
            this.Balance = 50000;
        }
        public Account(string name, long accountNumber)
        {
            if (accountNumber <= 0) this.AccountNumber = 999999;
            else this.AccountNumber = accountNumber;

            if (this.Name.Trim() == "") this.Name = "#UNDEFINED";
            else this.Name = name;
        }
        public Account(string name, long accountNumber, double balance)
        {
            if (accountNumber <= 0) this.AccountNumber = 999999;
            else this.AccountNumber = accountNumber;

            if (name.Trim() == "") this.Name = "#UNDEFINED";
            else this.Name = name;

            if (balance < 0) this.Balance = 50000;
            else this.Balance = balance;
        }
    }
}
