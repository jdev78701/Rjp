using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface ITransactionRepository:IBaseRepository<TransactionModel>
    {
        TransactionModel AddDeposit(int accountid,double? amount);
    }
}
