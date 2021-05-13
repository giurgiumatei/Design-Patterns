using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    public class SavingsAccountBuilder: IAccountBuilder
    {
        private Account _savingAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _savingAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _savingAccount.UserName = userName;
            _savingAccount.Password = password;
        }

        public void WithLoanAmount(double loanAmount)
        {
            return;
        }

        public void AddInterestRate(double interestRate)
        {
            return;
        }

        public void WithSavingBalance()
        {
            _savingAccount.Balance = 400000;
        }

        public Account GetAccount()
        {
            return _savingAccount;
        }
    }
}