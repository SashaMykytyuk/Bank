using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Credit : Account
    {
        public override decimal Balance { set; get; }
        public Credit(int _NumberAccount, int _Pin, Guid _Id, decimal _Balance) : base(_NumberAccount, _Pin, _Id, _Balance)
        {
            Balance = 30000;
        }
        public override bool GetMoney(decimal _money)
        {
            Balance -= _money;
            return true;
        }
    }
}
