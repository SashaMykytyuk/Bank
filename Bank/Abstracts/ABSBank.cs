using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class ABSBank
    {
        public string Name { set; get; }
        public ICollection<Client> clients { set; get; }
        public ABSBank(string _name)
        {
            Name = _name;
            clients = new List<Client>();
        }
        public ICollection<Client> GetAllClients()
        {
            return clients;
        }
        public ICollection<Client> AddNewClients(ICollection<Client> newClients)
        {
            ICollection<Client> clientsDontADD = new List<Client>();
            foreach (Client client in newClients)
            {
                if(clients.Contains(client)==false)
                {
                    clients.Add(client);
                }
                else if(client != null)
                {
                    clientsDontADD.Add(client);
                }
            }
            if (clientsDontADD.Count != 0)
                return clientsDontADD;
            else
                return null;
        }
        public ICollection<Client> RemoveClients(ICollection<Client> clientsToRemove)
        {
           
            ICollection<Client> clientsRemoved = new List<Client>();
            foreach(Client client in clients.Intersect(clientsToRemove,new ClientComparer()))
            {
                if (clients.Remove(client))
                    clientsRemoved.Add(client);
            }
            if (clientsRemoved.Count != 0)
                return clientsRemoved;
            else
                return null;
        }
        public ICollection<Account> GetAccountsByClient(Client client)
        {
           // if (client != null)
                return clients.Single(x => x.Id == client.Id).accounts;
           // else
               // return null;
        }
        public ICollection<Account> AddAccountsToClient(Client client, ICollection<Account> accounts)
        {
            client.accounts.Concat(accounts.Except(client.accounts.Intersect(RemoveNULL<Account>.DelNull(accounts), new AccountComparer())));
            return client.accounts;
        }
        public ICollection<Account> RemoveAccountsFromClient(Client client, ICollection<Account> accounts)
        {
            accounts = RemoveNULL<Account>.DelNull(accounts);
            client.accounts.Except(client.accounts.Intersect(accounts, new AccountComparer()));
            return client.accounts;
        }
        public decimal CheckBalance(Account account)
        {
            return account != null ?  account.Balance : 0;  
        }
        public bool AddMoneyToAccount(Account account, decimal quantity)
        {
            if (account != null && quantity > 0)
            {
                account.Balance += quantity;
                return true;
            }
            else
                return false;
        }
        public decimal GetMoneyFromAccount(Account account, decimal quantity)
        {
            if (account != null && quantity <= account.Balance)
            {
                account.Balance -= quantity;
                return quantity;
            }
            else
                return 0;
        }
    }
}
//Банк міститиме наступний функціонал:

//a) ICollection<Client> GetAllClients() - return all bank’s clients


//b)Bool AddNewClients(ICollection<Client> newClients) - returns true,
//if all new clients added, else - false
//c) ICollection<Client> RemoveClients(ICollection<Client>
//clientsToRemove) - returns actual removed clients
//d) ICollection<Account> GetAccountsByClient(Client client) - returns
//all client’s accounts
//Тестування ПЗ


//e) ICollection<Account> AddAccountsToClient(Client client,
//ICollection<Account> accounts) - returns collections with a new set
//of accounts


//f) ICollection<Account> RemoveAccountsFromClient(Client client,
//ICollection<Account> accounts) - returns a set of accounts which were
//actually removed


//g)Decimal CheckBalance(Account account) - return money quantity of a
//certain account
//
//h)Bool AddMoneyToAccount(Account account, decimal quantity) -
//returns true if operation succeed

    
    //i) Decimal GetMoneyFromAccount(Account account, decimal quantity)
//- return sum of money wich was removed from certain account