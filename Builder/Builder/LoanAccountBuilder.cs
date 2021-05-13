// using System;
//
// namespace Builder
// {
//     public class LoanAccountBuilder
//     {
//         private long _accountNumber;
//         private string _userName;
//         private string _password;
//         private double _loanAmount;
//         private double _interestRate;
//         private bool _loanStatus;
//
//         public LoanAccountBuilder WithAccountNumber(int accountNumber)
//         {
//             _accountNumber = accountNumber;
//             return this;
//         }
//
//         public LoanAccountBuilder WithCredential(string userName, string password)
//         {
//             _userName = userName;
//             _password = password;
//
//             return this;
//         }
//
//         public LoanAccountBuilder WithLoanAmount(double loanAmount)
//         {
//             _loanAmount = loanAmount;
//             return this;
//         }
//
//         public LoanAccountBuilder WithInterestRate(double interestRate)
//         {
//             _interestRate = interestRate;
//             return this;
//         }
//
//         public LoanAccountBuilder WithLoanStatus(bool loanStatus)
//         {
//             _loanStatus = loanStatus;
//             return this;
//         }
//
//         private bool CanBuild()
//         {
//             return _accountNumber > 0;
//         }
//
//         public LoanAccountBuilder Build()
//         {
//             return CanBuild() ? this : throw new Exception("Cannot build a valid object. Please check your arguments!");
//         }
//
//     }
// }