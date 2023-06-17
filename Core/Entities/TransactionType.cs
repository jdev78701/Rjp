using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int TransactionTypeId { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
