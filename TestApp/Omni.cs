using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Omni : Investment
    {
        private double overdraft = 500.00;
        //private bool omniIdentifier = true;

        public double Overdraft
        {
            get
            {
                return overdraft;
            }
            set
            {
                Overdraft = overdraft;
            }
        }

        //Constructor adds balance ONLY if the balance is over 1000
        public Omni(double balance, bool i) : base(balance, i)
        {

        }
    }
}
