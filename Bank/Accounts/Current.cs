
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Current : Account
    {
        public override decimal Balance { set; get; }
        public Current(Guid _Id, int _NumberAccount = 0, decimal _Balance = 0.0m, int _Pin = 0) : base(_Id, _NumberAccount, _Pin, _Balance)
        {
            Balance = 0;
        }
    }
}
