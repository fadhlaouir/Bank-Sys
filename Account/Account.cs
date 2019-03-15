using System;
using System.Collections.Generic;
using System.Text;

namespace BankSys.Account
{
    class Account<TClientKey, TTransaction, TAccKey> : AbstractAccount<TClientKey, TTransaction, TAccKey>
    {
        public Account(double taxRatio, double owner) : base(taxRatio, owner)
        {
        
        }
        public void Credit(double amount)
        {
//            //target.Balance += amount;
//            Transaction.State = Transactions<TTransaction, TAccKey>.State.Accepted;
//            Balance += amount;
//            this.Transactions.Add((TTransaction)Transaction);
        }
        public void Debit(double amount, TAccKey TAccKey)
        {
//            Transaction<TTransaction, TAccKey> transaction = new Transaction<TTransaction, TAccKey>(AccountNumber, amount, Transaction<TTransaction, TAccKey>.State.Ready, Transaction<TTransaction, TAccKey>.Direction.Outgoing);
//            if (Balance > amount)
//            {
//
//                Transaction.State = Transaction<TTransaction, TAccKey>.State.Accepted;
//                Balance -= amount;
//                this.Transactions.Add((TTransaction)Transaction);
//            }
//            else
//            {
//                Transaction.State = Transaction<TTransaction, TAccKey>.State.Rejected;
//            }
        }
        public void SendMoney(decimal amount, long target)
        {
//            if (Balance >= amount)
//            {
//                Balance -= amount;
//
//            }
//            Console.WriteLine("transaction Attempt Failed");
//
       }


    }
}
