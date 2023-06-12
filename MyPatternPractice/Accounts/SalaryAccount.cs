using System;

namespace MyPatternPractice.Accounts
{
    internal class SalaryAccount : Account, ICalculator
    {
        public SalaryAccount(double balance) : base(balance) { }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
