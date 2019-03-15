using System;
using System.Collections.Generic;
using System.Text;
using BankSys.Transaction;

namespace BankSys.Account
{
    public interface IAccount<TAccKey, TTransaction, TTransactionKey>
   
    {
        TAccKey AccountNumber { get; set; }
        State State { get; set; }
        IEnumerable<TTransactionKey> GetAllTransactions();
        void AddTransaction(TTransactionKey t);
        void Debit(double amount, TTransaction transaction,  TAccKey target);
        void Credit(double amount, TTransaction transaction, TAccKey target);
        void SendMoney(TTransaction transaction);
        IEnumerable<TTransactionKey> GetTransactionsByDate(DateTime dateTime);
        IEnumerable<TTransactionKey> GetTransactionsByTarget(TAccKey accountNumber);
        IEnumerable<TTransactionKey> GetTransactionsByQuery();
    }
}
