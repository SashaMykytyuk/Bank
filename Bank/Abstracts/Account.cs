using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        public int NumberAccount { set; get; }
        public int Pin { set; get; }
        public Guid Id { set; get; }
        public virtual decimal Balance { set; get; }
        public Account(Guid _Id, int _NumberAccount = 0, int _Pin = 0, decimal _Balance = 0.0m)
        {
            NumberAccount = _NumberAccount;
            Pin = _Pin;
            Id = _Id;
            Balance = _Balance;
        }
        public bool PutMoney(decimal _money)
        {
            Balance += _money;
            return true;
        }
        public virtual bool GetMoney(decimal _money)
        {
            if (Balance >= _money)
            {
                Balance -= _money;
                return true;
            }
            else
                return false;
        }
    }
}
