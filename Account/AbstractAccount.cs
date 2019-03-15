using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BankSys.Client;
using BankSys.Account;
using BankSys.Transaction;
using System.Linq;


namespace BankSys.Account
{
    public abstract class AbstractAccount<TClientKey, TTransaction, TAccKey , TTransactionKey> : IAccount<TAccKey, TTransaction, TTransactionKey>
    where TTransaction : Transaction<TTransactionKey, TAccKey>
    {
        public AbstractAccount(TClientKey clientKey, TAccKey accKey)
        {
            Balance = 0;
            AccKey = clientKey;
            TransactionList = new List<TTransaction>();
            AccountNumber = accKey;
            Date = DateTime.Now;
            State = State.Active;

        }
        public decimal Balance { get; set; }
        public TClientKey AccKey { get; set; }
        public TAccKey AccountNumber { get; set; }
        public State State { get; set; }
        public DateTime Date { get; set; }
        public double TaxRatio { get; set; }
        public List<TTransaction> TransactionList { get; set; }
        public abstract IEnumerable<TTransactionKey> GetAllTransactions();


        public abstract void AddTransaction(TTransactionKey t);
        public virtual void DebitAccount (double amount, TTransaction transaction, TAccKey target)
        { }
        public void Debit(double amount, TTransaction transaction, TAccKey target)
        {
            Balance -= (decimal) amount;
            SendMoney(transaction);
        }
        public virtual void CreditAccount (double amount, TTransaction transaction, TAccKey target)
        { }
        public void Credit(double amount, TTransaction transaction, TAccKey target)
        {
            Balance += (decimal) amount;
            SendMoney(transaction);
        }

        public void SendMoney(TTransaction transaction)
        {
            TransactionList.Add(transaction);
        }

        public abstract IEnumerable<TTransactionKey> GetTransactionsByDate(DateTime dateTime);


        public abstract IEnumerable<TTransactionKey> GetTransactionsByTarget(TAccKey accountNumber);


        public abstract IEnumerable<TTransactionKey> GetTransactionsByQuery();

    }
    public enum State
    {
        Active,
        Closed
    }
}
