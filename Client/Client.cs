using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankSys.Account;
using BankSys.Transaction;


namespace BankSys.Client
{
    public class Client<TAccEntity, TAccKey, TClientKey> : AbstractClient<TAccEntity, TClientKey>
    {
        public Client(TClientKey cin, string name) : base(cin, name)
        {

        }
        public override IEnumerable<TAccEntity> GetAllAccounts()
        {
            return Accounts;
        }
        public override TAccEntity GetAccount(TAccEntity accountNumber)
        {
            TAccEntity account = (
                from a in Accounts
                where accountNumber.Equals(a.AccountNumber)
                select a
            ).FirstOrDefault();

            return account;

        }
        public override void CreateAccount(TAccEntity account)
        {
            Accounts.Add(account);

        }

        public override void CloseAccount(TAccEntity account)
        {
            TAccEntity a = (
                from acc in Accounts
                where acc.AccountNumber.Equals(account.AccountNumber)
                select acc
                ).FirstOrDefault();
            a.State = AbstractAccount.State.Closed;
        }


        

       
       
    }
}
