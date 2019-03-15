using System;
using System.Collections.Generic;
using System.Text;

namespace BankSys.Client
{
    public interface IClient<TAccEntity>
    {
        IEnumerable<TAccEntity> GetAllAccounts();
        TAccEntity GetAccount(TAccEntity AccountNumber);
        void CreateAccount(TAccEntity Account);
        void CloseAccount(TAccEntity Account);
    }
}
