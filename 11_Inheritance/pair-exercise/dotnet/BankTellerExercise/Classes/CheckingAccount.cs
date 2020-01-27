using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CheckingAccount : BankAccount
    {

        

        public override decimal Withdraw(decimal amountToWithdraw)
        {

           
            if (Balance - amountToWithdraw < (decimal)0.00)
            {
                amountToWithdraw += (decimal)10.00;
            }
            if (Balance - amountToWithdraw > (decimal)-100.00)
            {
                base.Withdraw(amountToWithdraw);
            }

            return Balance;






        }
        
       




    }
}
