using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0923_02
{
    public class Customer
    {
        private System.Collections.ArrayList accounts;

        public Customer()
        {
            accounts = new System.Collections.ArrayList();
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public Account GetAccount(int AccountIndex)
        {
            return (Account)accounts[AccountIndex];
        }

        public System.Collections.ArrayList GetAccounts()
        {
            return accounts;
        }

        public void CreateAccount(decimal InitialDeposit)
        {
            if (InitialDeposit >= 1000)
            {

                Account a = new Account();
                a.Deposit(InitialDeposit);

                accounts.Add(a);
            }
        }
    }


    public class Account
    {
        private decimal balance;
        public int Number { get; set; }

        public decimal Balance
        {
            get { return balance; }
        }

      

        public string AccountInfo
        {
            get { return string.Format("Konto har {0} kr", Balance); }
           
        }


        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            balance = balance - amount;
        }
    }
}
