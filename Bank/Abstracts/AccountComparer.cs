using System.Collections.Generic;

namespace Bank
{
    internal class AccountComparer : IEqualityComparer<Account>
    {
        public bool Equals(Account x, Account y)
        {
            return x.NumberAccount == y.NumberAccount;
        }

        public int GetHashCode(Account obj)
        {
            return obj.GetHashCode();
        }
    }
}