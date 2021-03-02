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
            for (int i=0;i<MyBank.Length;i++)
            {
                if (MyBank[i]==null)
                {
                    MyBank[i] = account;
                    break;
                }
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            for(int i=0;i<MyBank.Length;i++)
            {
                if (MyBank[i].AccountNumber == accountNumber)
                {
                    MyBank[i]= null; 
                }

            }

        }
        public void Transection(int transectionType)
        {

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
