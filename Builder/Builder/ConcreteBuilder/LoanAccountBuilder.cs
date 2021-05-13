using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    public class LoanAccountBuilder: IAccountBuilder
    {
        private Account _loanAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _loanAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _loanAccount.UserName = userName;
            _loanAccount.Password = password;
        }

        public void WithLoanAmount(double loanAmount)
        {
            _loanAccount.LoanAmount = loanAmount;
        }

        public void AddInterestRate(double interestRate)
        {
            _loanAccount.InterestRate = interestRate;
        }

        public void WithSavingBalance()
        {
           return;
        }

        public Account GetAccount()
        {
            return _loanAccount;
        }
    }
}