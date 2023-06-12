using System;

namespace MyPatternPractice.Accounts
{
    internal abstract class Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        protected Account(double balance)
        {
            Balance = balance;
        }
    }
}
