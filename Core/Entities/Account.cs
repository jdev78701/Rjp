using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int AccountId { get; set; }
        public double? Balance { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
