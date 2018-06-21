using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountFactory accountFactory = new AccountFactory();
            ClientFactory clientFactory = new ClientFactory();

            ICollection<Account> accounts = new List<Account>();

            ABSBank privat = new Privat("Privat");

            var credit = accountFactory.GetAccount("Credit");
            var deposit = accountFactory.GetAccount("Deposit");
            var current = accountFactory.GetAccount("Current");
            accounts.Add(credit);
            accounts.Add(deposit);
            
            var student = clientFactory.GetClient("StudentClient");
            privat.AddAccountsToClient(student, accounts);

            accounts.Add(current);

            var vip_client = clientFactory.GetClient("VIPClient");

            privat.AddAccountsToClient(vip_client, accounts);


            








        }
        //ВІП-клієнт,
        //Клієнт-пенсіонер, Клієнт-студент, Звичайний-клієнт
    }
}
