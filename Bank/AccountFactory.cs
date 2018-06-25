using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountFactory
    {
        public Account GetAccount(string name)
        {
            switch(name)
            {
                case "Credit":
                    return new Credit(new Guid());
                    break;
                case "Current":
                    return new Current(new Guid());
                    break;
                case "Deposit":
                    return new Deposit(new Guid());
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
