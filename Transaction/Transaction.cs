using System;
using System.Collections.Generic;
using System.Text;

namespace BankSys.Transaction
{
    public class Transaction<TTransactionKey, TAccountkey>
    {
        public TTransactionKey TransactionNumber { get; set; }
        public TAccountkey Source { get; set; }
        public TAccountkey Target { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public State State { get; set; }
        public Direction Direction { get; set; }

    }
    public enum Direction
    {
        Incoming,
        Outgoing
    }
    public enum State
    {
        Ready,
        Accepted,
        Rejected
    }

}
