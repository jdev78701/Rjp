using Core.Context;
using Core.Interface;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class TransactionService : BaseService, ITransactionRepository
    {

        public TransactionService(Rjp_DatabaseContext _DatabaseContext) : base(_DatabaseContext)
        {
        }
        public TransactionModel Add(TransactionModel entity)
        {
            throw new NotImplementedException();
        }

        public TransactionModel AddDeposit(int accountid, double? amount)
        {
            TransactionModel transactionmodel = new TransactionModel();
            transactionmodel.Date = DateTime.Now;
            transactionmodel.Amount = amount;
            transactionmodel.TransactionTypeId = 1;
            transactionmodel.AccountId = accountid;
            var transactionSaved=_DatabaseContext.Transactions.Add(transactionmodel);
            _DatabaseContext.SaveChanges();
            return transactionSaved.Entity;
        }

        public IEnumerable<TransactionModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransactionModel GetById(int? id = 0)
        {
            throw new NotImplementedException();
        }

        public TransactionModel Update(TransactionModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
