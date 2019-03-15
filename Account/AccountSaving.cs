using System;
using System.Collections.Generic;
using System.Text;

namespace BankSys.Account
{
    class AccountSaving<TClientKey, TTransaction, TAccKey, TTransactionKey> : IAccount<TAccKey, TTransaction, TTransactionKey>
        where TTransaction : Transaction<TTransactionKey, TAccKey>
    {
        public TAccKey AccountNumber { get; set; }
        public State State { get; set; }
        public IEnumerable<TTransactionKey> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public void AddTransaction(TTransactionKey t)
        {
            throw new NotImplementedException();
        }

        public void Debit(double amount, TTransaction transaction, TAccKey target)
        {
            throw new NotImplementedException();
        }

        public void Credit(double amount, TTransaction transaction, TAccKey target)
        {
            throw new NotImplementedException();
        }

        public void SendMoney(TTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TTransactionKey> GetTransactionsByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TTransactionKey> GetTransactionsByTarget(TAccKey accountNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TTransactionKey> GetTransactionsByQuery()
        {
            throw new NotImplementedException();
        }
    }
}
