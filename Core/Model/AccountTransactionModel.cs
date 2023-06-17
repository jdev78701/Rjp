using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class AccountTransactionModel
    {
        public AccountModel accountModel { get; set; }
        public IEnumerable<TransactionModel> transactionModels { get;set; }
    }
}
