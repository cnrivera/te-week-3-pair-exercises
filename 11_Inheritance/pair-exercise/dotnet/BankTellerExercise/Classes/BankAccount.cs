using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
            Balance = 0;
        }

        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }


        public decimal Deposit(decimal amountToDeposit)
        {
            Balance = Balance + amountToDeposit;
            return Balance;
              
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance = Balance - amountToWithdraw;
            return Balance;
        }


        




        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            decimal startingBalance = Balance;
            this.Withdraw(transferAmount);

            if (Balance<startingBalance)
            {
                destinationAccount.Deposit(transferAmount);
            }
            
            
            

            
        }





    }
}
