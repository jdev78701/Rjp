using Core.Interface;
using Core.Model;
using Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Core.Service
{
    public class CustomerService : BaseService,ICustomerRepository
    {
        private ITransactionRepository _transactionRepository;
        private IAccountRepository _accountRepository;
        public CustomerService(ITransactionRepository transactionRepository,IAccountRepository accountRepository,Rjp_DatabaseContext _DatabaseContext):base(_DatabaseContext)
        {
            _transactionRepository = transactionRepository;
            _accountRepository = accountRepository;
        }
        public CustomerModel Add(CustomerModel entity)
        {
            _DatabaseContext.Customers.Add(entity);
            _DatabaseContext.SaveChanges();
            return entity;
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            return _DatabaseContext.Customers.Select(p=>(CustomerModel)p).ToList();
        }

        public CustomerModel GetById(int ?id=0)
        {
            return _DatabaseContext.Customers.Find(id);
        }

        public UserAccountModel GetCustomer(int id)
        {
            if (_DatabaseContext.Customers.Find(id) == null)
                return null;
            UserAccountModel userAccountModel = new UserAccountModel();
            userAccountModel.customerModel = GetById(id);
            var accounts = _accountRepository.GetAll().Where(p => p.CustomerId == id).ToList();
            foreach(var account in accounts)
            {
                AccountTransactionModel accountTransactionModel = new AccountTransactionModel();
                accountTransactionModel.transactionModels = _transactionRepository.GetAll().Where(tp => tp.AccountId == account.AccountId).ToList();
                accountTransactionModel.accountModel = account;
                userAccountModel.accountTrancationModels.Add(accountTransactionModel);
            }
            return userAccountModel;
        }

        public CustomerModel Update(CustomerModel entity)
        {
            var customer = GetById(entity?.CustomerId);
            if (customer != null)
            {
                customer.FirstName = entity?.FirstName;
                customer.LastName = entity?.LastName;
                _DatabaseContext.SaveChanges();
                return customer;
            }
            return null;
        }
    }
}
