using Builder.Product;

namespace Builder.Builder
{
    public interface IAccountBuilder
    {
        void AddAccountNumber(long accountNumber);
        void AddCredential(string userName, string password);
        void WithLoanAmount(double loanAmount);
        void AddInterestRate(double interestRate);
        void WithSavingBalance();
        Account GetAccount();

    }
}