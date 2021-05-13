using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    public class AccountConfigurationBuilder
    {
        public Account BuildLoanAccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(123456);
            builder.WithLoanAmount(500000);
            builder.AddInterestRate(10.5);

            return builder.GetAccount();
        }

        public Account BuildSavingAccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(654356);
            builder.WithSavingBalance();

            return builder.GetAccount();
        }
    }
}