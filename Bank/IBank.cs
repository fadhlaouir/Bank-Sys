using System;
using System.Collections.Generic;
using System.Text;
using BankSys.Transaction;

namespace BankSys.Bank
{
    public interface IBank
    {
        int Agent { get; set; }
        void AddAgent();
        void AddAgent(int NumbAgent);
        void RemoveAgent();
        void RemoveAgent(int NumbAgent);
        void AddTransaction(Transaction<int,int> transaction);
        void Load(string path);
        void Save(string path);
        //Transaction function (lazy)
        //accounts function(lazy)
        //client property;
        
    }
}
