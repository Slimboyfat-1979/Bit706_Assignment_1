using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Investment : Account
    {
       
        private double failFee = 10.00;
        private const double interestRate = 0.001;

        public double FailFee
        {
            get
            {
                return failFee;
            }

            set
            {
                FailFee = failFee;
            }
        }
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                InterestRate = interestRate;
            }
        }

        public Investment(double balance, bool i) : base(balance)
        {
            if(i == true)
            {
                if(balance >= 1000)
                {
                    balance = calcInterest(balance);
                    this.Balance = balance;
                }
                else
                {
                    Balance = balance;
                }
            }
            else
            {
                balance = calcInterest(balance);
                this.Balance = balance;
            }
        }

        public double calcInterest(double balance)
        {
            double interest = balance * InterestRate;
            balance = balance + interest;
            return balance;
        }

        public override double withdrawal(double value, double balance)
        {
            
            if (value > balance)
            {
                return balance - FailFee;
            }
            else
            {
                balance = balance - value;
                return balance;
            }
        }

        public bool failed(double value, double balance, bool isStaffMember)
        {
            if(value > balance)
            {
                if(isStaffMember == true)
                {
                    failFee = failFee * 0.5;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
