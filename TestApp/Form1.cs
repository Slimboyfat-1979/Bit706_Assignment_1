using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    { 
        int accountType;
        int transactionType;
        double balance;
        bool staffAccount = false;
        string[] type = { "Everyday", "Investment", "Omni" };

        Account a1 = new Account(564.23);
        Investment a2 = new Investment(1000, false);
        Omni a3 = new Omni(1500, true);

        List<string> transactions = new List<string>();

      

        //=========Could maybe read in values here to initialize accounts=============
        public Form1()
        {
            InitializeComponent();
            a1.setRates(0);
            a2.setRates(1);
            a3.setRates(2);
        }

        private void boxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountType = boxAccountType.SelectedIndex;
            if(accountType == 0)
            { 
                lblValue.Text = "ID: " + a1.GetID() + " " + type[0] + "; " + "\nInterest Rate: " + a1.getInterestRate() + "%; " + "Overdraft Limit: $" + a1.getOverdraft() + ";\n" +
                     "Balance: $" + a1.Balance;
            }

            if (accountType == 1)
            {
                lblValue.Text = "ID: " + a2.GetID() + " " + type[1] + "; " + "\nInterest Rate: " + a2.getInterestRate() + "%; " + "Overdraft Limit: $" + a2.getOverdraft() + ";\n" +
                      "Balance: $" + a2.Balance;
            }

            if (accountType == 2)
            {
                
                lblValue.Text = "ID: " + a3.GetID() + " " + type[2] + "; " + "\nInterest Rate: " + a3.getInterestRate() + "%; " + "Overdraft Limit: $" + a3.getOverdraft() + ";\n" +
                     "Balance: $" + (a3.Balance);
            }

        }

        private void boxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionType = boxTransactionType.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string transactionValues;
            double value = Convert.ToDouble(valueInput.Text);

            if (checkBox1.CheckState == CheckState.Checked)
            {
                staffAccount = true;
            }

            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                staffAccount = false;
            }

            valueInput.Clear();

            //Everyday Account
            if (accountType == 0)
            {
                balance = a1.Balance;

                //Everyday Deposit
                if (transactionType == 0)
                {
                    double transactionDep = a1.deposit(value, balance);
                    a1.Balance = transactionDep;

                    transactionValues = "ID: " + a1.GetID() + " " + type[0] + "; " + "\nInterest Rate: " + a1.getInterestRate() + "%; " + "Overdraft Limit: $" + a1.getOverdraft() + ";\n" +
                    "Fee: $" + a1.getFee() + " Balance: $" + a1.Balance;
                    lblValue.Text = transactionValues;
                    transactions.Add(transactionValues);
                }
                //Everyday Withdrawal
                if (transactionType == 1)
                {
                    double transactionWithdrawal = a1.withdrawal(value, balance);
                    if (transactionWithdrawal == -1)
                    {
                        transactionValues = "You do not have enough funds \n to process this transaction :( \n" +
                           "You have inccured a fee of $" + a2.getFee() + "\nYour balance is " + a1.Balance;
                        lblValue.Text = transactionValues;
                        transactions.Add(transactionValues);
                    }
                    else
                    {
                        a1.Balance = transactionWithdrawal;
                        transactionValues = "ID: " + a1.GetID() + " " + type[0] + "; " + "\nInterest Rate: " + a1.getInterestRate() + "%; " + "Overdraft Limit: $" + a1.getOverdraft() + ";\n" +
                        "Fee: $" + a1.getFee() + "; " + "Balance: $" + a1.Balance;
                        lblValue.Text = transactionValues;
                        transactions.Add(transactionValues);
                    }
                }
            }

            //Invesment account
            if (accountType == 1)
            {
                /* Calculate the interest by taking the returned balance from the deposit
                  and entering that value into the calculate interest method which
                 is then assigned to the objects balance and printed on the screen */

                balance = a2.Balance;
                //Investment Deposit
                if (transactionType == 0)
                {
                    double transactionDep = a2.deposit(value, balance);
                    a2.Balance = a2.calcInterest(transactionDep);
                    transactionValues = "ID: " + a2.GetID() + " " + type[1] + "; " + "\nInterest Rate: " + a2.getInterestRate() + "%; " + "Overdraft Limit: $" + a2.getOverdraft() + ";\n" +
                    "Fee: $" + a2.getFee() + "; " + "Balance: $" + a2.Balance;
                    lblValue.Text = transactionValues;
                    transactions.Add(transactionValues);
                }
                //Investment Withdrawal
                if (transactionType == 1)
                {
                    double transactionWith = a2.withdrawal(value, balance);
                    if (a2.failed(value, balance, staffAccount) == true)
                    {
                        a2.Balance = transactionWith;
                        transactionValues = "You have incurred a $10 fee for the failed transaction \n" +
                            "ID: " + a2.GetID() + " " + type[1] + "\nInterest Rate: " + a2.getInterestRate() + "%; " + "Overdraft Limit: $" + a2.getOverdraft() + ";\n" +
                   "Fee: $" + a2.getFee(1) + " Balance: $" + a2.Balance;
                        lblValue.Text = transactionValues;
                        transactions.Add(transactionValues);
                    }
                    else
                    {
                        a2.Balance = transactionWith;
                        transactionValues = "ID: " + a2.GetID() + " " + type[1] + "\nInterest Rate: " + a2.getInterestRate() + "%; " + "Overdraft Limit: $" + a2.getOverdraft() + ";\n" +
                  "Fee: $" + a2.getFee() + " Balance: $" + a2.Balance;
                        lblValue.Text = transactionValues;
                        transactions.Add(transactionValues);
                    }
                }
            }

            //Omni Account
            if (accountType == 2)
            {
                balance = a3.Balance;
                //Omni Deposit
                if (transactionType == 0)
                {
                    double transactionDep = a3.deposit(value, (balance + a3.Overdraft));
                    a3.Balance = (transactionDep - a3.Overdraft);

                    transactionValues = "ID: " + a3.GetID() + " " + type[2] + "; " + "\nInterest Rate: " + a3.getInterestRate() + "%; " + "Overdraft Limit: $" + a3.getOverdraft() + ";\n" +
                   "Fee: $" + a3.getFee() + "; " + "Balance: $" + a3.Balance;
                    lblValue.Text = transactionValues;
                    transactions.Add(transactionValues);
                }
                //Omni Withdrawal
                if (transactionType == 1)
                {
                    balance = a3.Balance;
                    double transactionWith = a3.withdrawal(value, (balance + a3.Overdraft));

                    if (a3.failed(value, (balance + a3.Overdraft), staffAccount) == true)
                    {
                        a3.Balance = transactionWith - a3.Overdraft;
                        transactionValues = "you have incurred a $10 fee for the failed transaction \n" +
                            "ID: " + a3.GetID() + " " + type[2] + "\nInterest Rate: " + a3.getInterestRate() + "%; " + "Overdraft Limit: $" + a3.getOverdraft() + ";\n" +
                   "Fee: $" + a3.getFee(1) + " Balance: $" + a3.Balance;
                        lblValue.Text = transactionValues;
                        transactions.Add(transactionValues);
                    }
                    else
                    {
                        a3.Balance = transactionWith - a3.Overdraft;
                        transactionValues = "ID: " + a3.GetID() + " " + type[2] + "\nInterest Rate: " + a3.getInterestRate() + "%; " + "Overdraft Limit: $" + a3.getOverdraft() + ";\n" +
                        "Fee: $" + a3.getFee() + " Balance: $" + a3.Balance;
                        lblValue.Text = transactionValues;
                        transactions.Add(transactionValues);
                    }
                }
            }
        }
    }
}
