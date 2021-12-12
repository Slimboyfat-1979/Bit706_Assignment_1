using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Account
    {
       private int id;
       static int nextId = 1;
       private int isEnough;
       private double interestRate;
       private double overdraft;
       private double fee;

        //======Methods for printing out values on the GUI========
    
       public double getInterestRate()
        {
            return interestRate;
        }

        public double getOverdraft()
        {
            return overdraft;
        }

        public double getFee()
        {
            return fee;
        }

        public void setRates(int type)
        {
            if(type == 0)
            {
                interestRate = 0;
                overdraft = 0;
                fee = 0;
            }
            if(type == 1)
            {
                interestRate = 0.001;
                overdraft = 0;
                fee = 10;
            }
            if(type == 2)
            {
                interestRate = 0.001;
                overdraft = 500;
                fee = 10;
            }
        }

        public double Balance { get; set; }

        List<Account> accountList = new List<Account>();

        public List<Account> getAccounts()
        {
            return this.accountList;
        }

        public int GetID()
        {
            return this.id;
        }

        public Account()
        {
            this.id = nextId;
            nextId++;
        }

        public Account(double balance) : this()
        {
            this.Balance = balance;
        }

        public double deposit(double value, double balance)
        {
            return balance = balance + value;
        }

        public virtual double withdrawal(double value, double balance)
        {
            if(value > balance)
            {
                isEnough = -1;
                return isEnough;
            }
            else
            {
                balance = balance - value;
                return balance;
            }
        }
    }
}
