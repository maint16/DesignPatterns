using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var cityAcc = factory.GetSavingsAccount("city");
            var nationAcc = factory.GetSavingsAccount("national");
            Console.WriteLine($"City {cityAcc.Balance} and national {nationAcc.Balance}");
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Product
    /// </summary>
    public abstract class SavingsAccount
    {
        public decimal Balance { get; set; }
    }

    /// <summary>
    /// Concrete product
    /// </summary>
    public class CitySavingsAcct : SavingsAccount
    {
        public CitySavingsAcct()
        {
            Balance = 5000;
        }
    }

    /// <summary>
    /// Concrete product
    /// </summary>
    public class NationalSavingsAcct : SavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    /// <summary>
    /// Creator
    /// </summary>
    interface ICreditUnionFactory
    {
        SavingsAccount GetSavingsAccount(string acctNo);
    }

    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public SavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("city"))
                return new CitySavingsAcct();
            if (acctNo.Contains("national"))
                return new NationalSavingsAcct();
            throw new Exception("");

        }
    }
}
