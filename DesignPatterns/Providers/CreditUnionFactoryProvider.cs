using System;
using CitiCreditUnion;
using Interfaces;
using NationalCreditUnion;

namespace Providers
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if(accountNo.Contains("city")) return new CityCreditUnionFactory();
            if(accountNo.Contains("national")) return new NationalCreditUnionFactory();
            return null;
        }
    }
}
