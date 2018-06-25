using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        AccountFactory accountFactory = new AccountFactory();
        ClientFactory clientFactory = new ClientFactory();
        ICollection<Account> accounts = new List<Account>();
        ABSBank privat = new Privat("Privat");


        [TestMethod]
        public void TestGetAllClient()
        {
            ICollection<Client> clients = new List<Client>();
            clients.Add(clientFactory.GetClient("StudentClient"));
            clients.Add(clientFactory.GetClient("VIPClient"));
            privat.AddNewClients(clients);
            Assert.IsTrue(privat.clients.Count == 2);
        }
        [TestMethod]
        
    }
}




//public ICollection<Client> AddNewClients(ICollection<Client> newClients)

//public ICollection<Client> RemoveClients(ICollection<Client> clientsToRemove)

//public ICollection<Account> GetAccountsByClient(Client client)

//public ICollection<Account> AddAccountsToClient(Client client, ICollection<Account> accounts)

//public ICollection<Account> RemoveAccountsFromClient(Client client, ICollection<Account> accounts)

//public decimal CheckBalance(Account account)

//public bool AddMoneyToAccount(Account account, decimal quantity)

//public decimal GetMoneyFromAccount(Account account, decimal quantity)

