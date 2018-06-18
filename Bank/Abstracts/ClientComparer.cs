using System.Collections.Generic;

namespace Bank
{
    internal class ClientComparer : IEqualityComparer<Client>
    {
        public bool Equals(Client x, Client y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Client obj)
        {
            return obj.GetHashCode();
        }
    }
}