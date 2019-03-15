using System;
using System.Collections.Generic;
using System.Text;


namespace BankSys.Client
{
    public abstract class AbstractClient<TAccEntity, TClientKey> : IClient<TAccEntity>
    {
        public TClientKey CIN { get; set; }
        public string Name { get; set; }
        public List<TAccEntity> Accounts { get; set; }

        protected AbstractClient(TClientKey cin, string name)
        {
            CIN = cin;
            Name = name;
            Accounts = new List<TAccEntity>();
//            Log.Logger.ForContext<AbstractClient>();
        }

        public abstract void CreateAccount(TAccEntity account);
        public abstract void CloseAccount(TAccEntity account);
        public abstract TAccEntity GetAccount(TAccEntity AccountNumber);
        public abstract IEnumerable<TAccEntity> GetAllAccounts();

    }
}
