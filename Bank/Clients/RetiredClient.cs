using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class RetiredClient:Client
    {
        public override double InterestRate { set; get; } //відсоткова ставка
        public RetiredClient(string _FirstName, string _LastName, Guid _Id) : base(_FirstName, _LastName, _Id)
        {
            InterestRate = 5;
        }
    }
}
