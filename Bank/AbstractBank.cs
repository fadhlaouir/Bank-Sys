using System;
using System.Collections.Generic;
using System.Text;
using BankSys.Client;
using BankSys.Transaction;


namespace BankSys.Bank
{
    class AbstractBank
    {
        public string Name { get;set; }
        public int SwiftCode { get; set; }
        public List<Client<string,int,int>> ListClients { get; set; }
        public List<Transaction<int,int>> ListTransactions { get; set; }
        

        public void Bank(string name)
        {
            ListTransactions= new List<Transaction<int, int>>();
            ListClients = new List<Client<string, int, int>>();
            Name = name;
//            Log.Logger.ForContext<AbstractBank>();
        }

    }
}
