using System;

namespace MyPatternPractice.Accounts
{
    internal class CasualAccount : Account, ICalculator
    {
        public CasualAccount(double balabce) : base(balabce) { }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= (Balance * 0.2);
            if (Balance >= 1000)
                Interest -= (Balance * 0.4);
        }
    }
}
