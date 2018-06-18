using Bank.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit : Account
    {
        public override decimal Balance { set; get; }
        public Deposit(int _NumberAccount, int _Pin, Guid _Id, decimal _Balance) : base(_NumberAccount, _Pin, _Id, _Balance)
        {
            Balance = 0;
        }
    }
}
