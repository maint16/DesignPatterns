using System;

namespace Interfaces
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    /// <summary>
    /// Abstract Product A
    /// </summary>
    public interface ILoanAccount { }

    /// <summary>
    /// Abstract Product B
    /// </summary>
    public interface ISavingsAccount
    {

    }
}
