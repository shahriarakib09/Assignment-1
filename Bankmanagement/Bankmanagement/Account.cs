using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankmanagement
{
    class Account
    {
        private int accountNumber= 1 ;
        private static int myaccountNumber;
        private string accountName;
        private Double balance;
        private Address address;

        public Account(string accountName, double balance, Address address)
        {
            accountNumber = ++myaccountNumber;
            this.AccountName = accountName;
            this.Balance = balance;
            this.Address = address;
        }
        //public int AccountNumber
        //{
        //    int i = 0;

        //    set { this.accountNumber = value; }
        //    get { return this.accountNumber; }
        //}
        public String AccountName
        {
            set { this.accountName = value; }
            get
            {
                return accountName;
            }   
        }
        public double Balance 
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public void Withdraw(double amount)
        {
            if(this.Balance-amount>=500)
            {
                this.Balance = this.Balance - amount;
                Console.WriteLine("Withdraw successful");

            }
            else
            {
                Console.WriteLine("Insufficiant Balance");
            }
        }
        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            Console.WriteLine("Deposited successfully");

        }
        public void Transfer(double amount,Account receiver )
        {
            
            this.Withdraw(amount);
            receiver.Deposit(amount);
        }
       public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", accountNumber, this.accountName, this.balance);
            Console.WriteLine(this.Address.GetAddress());
        }

        
    }
}
