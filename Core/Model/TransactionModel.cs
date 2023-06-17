using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public double? Amount { get; set; }
        public int TransactionTypeId { get; set; }
        public int AccountId { get; set; }
    }
}
