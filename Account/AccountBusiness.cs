using System;
using System.Collections.Generic;
using System.Text;
using BankSys.Transaction;
using BankSys.Account;

namespace BankSys.Account
{
    class AccountBusiness<TClientKey, TTransaction, TAccKey, TTransactionKey> : AbstractAccount<TClientKey, TTransaction, TAccKey, TTransactionKey> where TTransaction : Transaction<TTransactionKey, TAccKey>
    {
        
        public AccountBusiness(TClientKey clientKey, TAccKey accKey) : base(clientKey, accKey)
        {
            TaxRatio = 0.01;
        }

        public override void DebitAccount(double amount, TTransaction transaction, TAccKey target)
        {
            double result = (TaxRatio * amount) + amount;
            if (Balance > (decimal) result)
            {
                transaction.State = Transaction.State.Accepted;
                base.DebitAccount(amount, transaction, target);
            }
            else
            {
                transaction.State = Transaction.State.Rejected;
                throw new Exception("No, you can't ! Sorry ");
            }
            
        }

        public override void CreditAccount(double amount, TTransaction transaction, TAccKey target)
        {
            if (State == State.Closed)
            {
                throw new Exception("Fuck off");
            }
            base.CreditAccount(amount, transaction, target);
        }

        public override IEnumerable<TTransactionKey> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public override void AddTransaction(TTransactionKey t)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TTransactionKey> GetTransactionsByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TTransactionKey> GetTransactionsByTarget(TAccKey accountNumber)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TTransactionKey> GetTransactionsByQuery()
        {
            throw new NotImplementedException();
        }
    }
}
