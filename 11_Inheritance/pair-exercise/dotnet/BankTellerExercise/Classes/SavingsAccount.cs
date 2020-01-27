using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
            if (Balance < (decimal) 150.00)
            {
                base.Withdraw(amountToWithdraw + (decimal)2.00);
            }
            else if (amountToWithdraw > Balance)
            { 
                base.Withdraw(0);
            }

            return Balance;
        }






    }
}
