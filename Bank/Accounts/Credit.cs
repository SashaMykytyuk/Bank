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
        public Credit(Guid _Id, int _NumberAccount = 0, decimal _Balance = 0.0m, int _Pin = 0) : base(_Id, _NumberAccount, _Pin, _Balance)
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
