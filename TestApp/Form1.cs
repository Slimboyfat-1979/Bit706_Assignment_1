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
        string[] type = { "Everyday", "Investment", "Omni" };

        Account a1 = new Account(564.23);
        Investment a2 = new Investment(1000, false);
        Omni a3 = new Omni(1500, true);

      

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
                    "Fee: $" + a1.getFee() + "; " + "Balance: $" + a1.Balance;
            }

            if (accountType == 1)
            {
                //lblValue.Text = "ID: " + a2.GetID() + " " + type[1] + "; " + "\nInterest Rate: " + a2.getInterestRate() + "%; " + "Overdraft Limit: $" + a2.getOverdraft() + ";\n" +
                   // "Fee: $" + a2.getFee() + "; " + "Balance: $" + a2.Balance;


                //lblValue.Text = type[0] + "; " + "Interest Rate: " + a2.getInterestRate() + "%";

                //lblValue.Text = Convert.ToString(a2.GetID()) + " " + type[1] + " $" + a2.Balance;
            }

            if (accountType == 2)
            {
                double omniBalance = a3.Balance + a3.Overdraft;
                lblValue.Text = Convert.ToString(a3.GetID()) + " " + type[2] + " $" + omniBalance;
            }

        }

        private void boxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionType = boxTransactionType.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(valueInput.Text);

            valueInput.Clear();
            //========Figure out which account do I need to create an object for ===========

            //Logic for what to do if the account type is Everyday
            if(accountType == 0)
            {
                /* Get the balance from the everyday account
                 * Take the value, and the balance and send to the account deposit/withdrawal
                 method then reassign the new balance
                 If the transaction is a withdrawal check to see if there is enough
                 funds if not display appropriate message*/

                balance = a1.Balance;
                if(transactionType == 0)
                {
                    double transactionDep = a1.deposit(value, balance);
                    a1.Balance = transactionDep;
                    //lblValue.Text = "Your balance is now $" + Convert.ToString(a1.Balance);

                    lblValue.Text = "ID: " + a1.GetID() + " " + type[0] + "; " + "\nInterest Rate: " + a1.getInterestRate() + "%; " + "Overdraft Limit: $" + a1.getOverdraft() + ";\n" +
                    "Fee: $" + a1.getFee() + "; " + "Balance: $" + a1.Balance;
                }

                if(transactionType == 1)
                {
                    double transactionWithdrawal = a1.withdrawal(value, balance);
                    if(transactionWithdrawal == -1)
                    {
                        lblValue.Text = "You do not have enough funds \n to process this transaction :( \n" +
                            "Your balance is " + a1.Balance;
                    }
                    else
                    {
                        a1.Balance = transactionWithdrawal;
                        //lblValue.Text = "Your balance is now $" + Convert.ToString(a1.Balance);

                        lblValue.Text = "ID: " + a1.GetID() + " " + type[0] + "; " + "\nInterest Rate: " + a1.getInterestRate() + "%; " + "Overdraft Limit: $" + a1.getOverdraft() + ";\n" +
                        "Fee: $" + a1.getFee() + "; " + "Balance: $" + a1.Balance;
                    }
                }
            }
            if(accountType == 1)
            {
                /* Calculate the interest by taking the returned balance from the deposit
                  and entering that value into the calculate interest method which
                 is then assigned to the objects balance and printed on the screen */
                balance = a2.Balance;
                if(transactionType == 0)
                {
                    double transactionDep = a2.deposit(value, balance);
                    a2.Balance = a2.calcInterest(transactionDep);
                    lblValue.Text = "Your balance is now $" + Convert.ToString(a2.Balance);
                }

                if(transactionType == 1)
                {
                    double transactionWith = a2.withdrawal(value, balance);
                    if(a2.failed(value, balance) == true)
                    {
                        a2.Balance = transactionWith;
                        lblValue.Text = "You incurred a $20 fee for a failed transaction \n your balance is now $" +
                            Convert.ToString(a2.Balance);
                    }
                    else
                    {
                        a2.Balance = transactionWith;
                        lblValue.Text = "Your balance is now $" + Convert.ToString(a2.Balance);
                    }  
                }  
            }
            if(accountType == 2)
            {
                balance = a3.Balance;
                //lblValue.Text = Convert.ToString(a3.Balance);
                if(transactionType == 0)
                {
                    double transactionDep = a3.deposit(value, balance);
                    a3.Balance = transactionDep;
                    lblValue.Text = "You balance is now $" + Convert.ToString(a3.Balance);
                }

                if(transactionType == 1)
                {
                    double transactionWith = a3.withdrawal(value, balance);
                    if (a3.failed(value, balance) == true)
                    {
                        a3.Balance = transactionWith;
                        lblValue.Text = "You incurred a $20 fee for a failed transaction \n your balance is now $" +
                            Convert.ToString(a3.Balance);
                    }
                    else
                    {
                        a3.Balance = transactionWith;
                        lblValue.Text = "Your balance is now $" + Convert.ToString(a3.Balance);
                    }

                }
                
                //Enter omni details here;
            }
        }
    }
}
