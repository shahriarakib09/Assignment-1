using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankmanagement
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName, int size)

        {
            this.bankName = bankName;
            myBank = new Account[size];
        }
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            for (int i = 1; i < MyBank.Length; i++)
            {
                if (MyBank[i] == null)
                {
                    MyBank[i] = account;
                    Console.WriteLine("Account Added");

                    break;
                }
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            for (int i = 0; i <MyBank.Length; i++)
            {
                if (MyBank[i]== MyBank[accountNumber])
                {
                    MyBank[i] = null;
                    Console.WriteLine("Account deleted");
                    break;
                }

            }

        }
        public void Transaction(int transactionType)
        {
            int amount,receiver;
            //Console.WriteLine("Enter 1 for withdraw");
            //Console.WriteLine("Enter 2 for deposit");
            //Console.WriteLine("Enter 3 for transfer");

            Console.WriteLine("Enter account number: ");

            int accountnumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < MyBank.Length; i++)
            {
        

            if (MyBank[i] == MyBank[accountnumber])
                {
                    if (transactionType == 1)
                    {

                        Console.WriteLine("Enter amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        MyBank[accountnumber].Withdraw(amount);
                    }

                    else if (transactionType == 2)
                    {
                        Console.WriteLine("Enter amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        MyBank[accountnumber].Deposit(amount);
                    }

                    else if (transactionType == 3)
                    {
                        //Console.WriteLine("Enter amount and revceiver id");
                        //amount = Convert.ToInt32(Console.ReadLine());
                        //receiver = Convert.ToInt32(Console.ReadLine());
                        ////MyBank[accountnumber].Transfer(amount, receiver);
                    }

                    else
                        Console.WriteLine("invalid request");

                    break;

                }
            }
        }


            public void PrintAccountDetailes()
                {
                    for (int i = 0; i < MyBank.Length; i++)
                    {
                        if (MyBank[i] == null)
                        {
                            continue;
                        }
                        MyBank[i].ShowAccountInformation();
                    }

                }
           
    }
        
}
    


