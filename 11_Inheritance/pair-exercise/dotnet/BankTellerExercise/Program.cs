using System;
using BankTellerExercise.Classes;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Testing part one math in the various account rules. Result should be -60, 150.

            BankAccount checkingAccount = new CheckingAccount();
            BankAccount savingsAccount = new SavingsAccount();

            decimal amountToDeposit = 100.00M;
            decimal newBalance = checkingAccount.Deposit(amountToDeposit);

            decimal amountToTransfer = 50.00M;
            checkingAccount.Transfer(savingsAccount, amountToTransfer);

            amountToTransfer = 100.00M;
            checkingAccount.Transfer(savingsAccount, amountToTransfer);

            amountToTransfer = 100.00M;
            checkingAccount.Transfer(savingsAccount, amountToTransfer);


            //Testing part two results.

            Console.WriteLine(checkingAccount.Balance);
            Console.WriteLine(savingsAccount.Balance);

            checkingAccount = new CheckingAccount();
            savingsAccount = new SavingsAccount();

            BankCustomer jayGatsby = new BankCustomer();
            jayGatsby.AddAccount(checkingAccount);
            jayGatsby.AddAccount(savingsAccount);


            Console.WriteLine($"Jay Gatsby has {jayGatsby.Accounts.Length} accounts.");
        }
    }
}
