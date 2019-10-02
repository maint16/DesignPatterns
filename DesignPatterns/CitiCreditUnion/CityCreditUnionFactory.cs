using System;
using Interfaces;

namespace CitiCreditUnion
{
    /// <summary>
    /// Concrete Product A1
    /// </summary>
    public class CitySavingsAccount : ISavingsAccount
    {
        public CitySavingsAccount()
        {
            Console.WriteLine("Returned city savings account");
        }
    }

    /// <summary>
    /// Concrete Product B1
    /// </summary>
    public class CityLoanAccount : ILoanAccount
    {
        public CityLoanAccount()
        {
            Console.WriteLine("Returned city loan account.");
        }
    }

    public class CityCreditUnionFactory : ICreditUnionFactory
    {
        public override ISavingsAccount CreateSavingsAccount()
        {
          CitySavingsAccount obj = new CitySavingsAccount();
          return obj;
        }

        public override ILoanAccount CreateLoanAccount()
        {
            CityLoanAccount obj = new CityLoanAccount();
            return obj;
        }
    }
}
