using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    class BankCustomer
    {

        private List<BankAccount> customerList = new List<BankAccount>();




        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public BankAccount[] Accounts
        {
            get
            {
                return customerList.ToArray();
            }

        }
        public bool IsVIP
        {
            get
            {
                decimal sum = 0;
                foreach (BankAccount account in Accounts)
                {
                    sum += account.Balance;
                    
                }

                if (sum >= 25000)
                {
                    return true;
                }
                return false;
                    
                

            }
        }

        public BankCustomer()
        {

        }

        

        public void AddAccount(BankAccount newAccount)
        {
            customerList.Add(newAccount);
        }



    }
}
