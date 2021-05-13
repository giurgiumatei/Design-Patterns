using System;
using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Director;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // var loanAccount1 = new LoanAccountBuilder()
            //     .WithAccountNumber(12345)
            //     .WithCredential("john", "pwd")
            //     .WithLoanAmount(400000)
            //     .Build();
            //
            // var loanAccount2 = new LoanAccountBuilder()
            //     .WithLoanStatus(true)
            //     .WithLoanAmount(40000)
            //     .WithInterestRate(10.5)
            //     .Build();

            IAccountBuilder builder1 = new LoanAccountBuilder();
            AccountConfigurationBuilder configurationBuilder1 = new AccountConfigurationBuilder();

            var loanAccount = configurationBuilder1.BuildLoanAccount(builder1);

            Console.WriteLine($"The loan account detail - Account Number: {loanAccount.AccountNumber}" +
                              $" Loan Amount: {loanAccount.LoanAmount}");
            
            IAccountBuilder builder2 = new SavingsAccountBuilder();
            AccountConfigurationBuilder configurationBuilder2 = new AccountConfigurationBuilder();

            var savingAccount = configurationBuilder2.BuildSavingAccount(builder2);

            Console.WriteLine($"The saving account detail - Account Number: {savingAccount.AccountNumber}" +
                              $" Loan Amount: {savingAccount.Balance}");
        }
    }
}