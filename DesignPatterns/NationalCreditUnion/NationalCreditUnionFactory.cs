using System;
using Interfaces;

namespace NationalCreditUnion
{
    /// <summary>
    /// Product A2
    /// </summary>
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned national savings account.");
        }
    }

    /// <summary>
    /// Product B2
    /// </summary>
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned national loan account.");
        }
    }

    /// <summary>
    /// Concrete Factory 2
    /// </summary>
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount obj = new NationalSavingsAccount();
            return obj;
        }

        public override ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount obj = new NationalLoanAccount();
            return obj;
        }
    }
}
