using Core.Context;
using Core.Interface;
using Core.Model;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class AccountService : BaseService, IAccountRepository
    {
        private ITransactionRepository _transactionRepository;
        public AccountService(ITransactionRepository transactionRepository,Rjp_DatabaseContext _DatabaseContext) : base(_DatabaseContext)
        {
            _transactionRepository = transactionRepository;
        }
        public AccountModel Add(AccountModel entity)
        {
            try
            {
                var accountModelSaved=_DatabaseContext.Accounts.Add(entity);

                _DatabaseContext.SaveChanges();
                if (entity.Balance != 0)
                {
                    _transactionRepository.AddDeposit(accountModelSaved.Entity.AccountId, entity.Balance);
                }
                return entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<AccountModel> GetAll()
        {
            return _DatabaseContext.Accounts.Select(p => (AccountModel)p).ToList();
        }

        public AccountModel GetById(int? id = 0)
        {
            throw new NotImplementedException();
        }

        public AccountModel Update(AccountModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
