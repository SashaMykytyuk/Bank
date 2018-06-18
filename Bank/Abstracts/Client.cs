using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Client
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public Guid Id { set; get; }
        public ICollection<Account> accounts;
        public virtual double InterestRate { set; get; } //відсоткова ставка
        public Client(string _FirstName, string _LastName, Guid _Id)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Id = _Id;
            accounts = new List<Account>();
            InterestRate = 0;
        }
       
    }
}
