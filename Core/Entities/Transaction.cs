using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public double? Amount { get; set; }
        public int TransactionTypeId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
