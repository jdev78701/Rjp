using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public partial class Transaction
    {
        public static implicit operator TransactionModel(Transaction transaction)
        {

            TransactionModel transactionDto = new TransactionModel();
            transactionDto.AccountId = (int)transaction?.AccountId;
            transactionDto.Date = (DateTime)(transaction?.Date);
            transactionDto.TransactionTypeId= (int)(transaction?.TransactionTypeId);
            transactionDto.TransactionId = (int)(transaction?.TransactionId);
            transactionDto.Amount = transaction?.Amount;
            return transactionDto;
        }

        public static implicit operator Transaction(TransactionModel transactionModel)
        {

            Transaction transaction = new Transaction();
            transaction.AccountId = (int)transactionModel?.AccountId;
            transaction.Date = (DateTime)(transactionModel?.Date);
            transaction.TransactionTypeId = (int)(transactionModel?.TransactionTypeId);
            transaction.TransactionId = (int)(transactionModel?.TransactionId);
            transaction.Amount = transactionModel?.Amount;
            return transaction;
        }
    }
}
