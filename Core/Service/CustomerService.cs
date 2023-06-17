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
        public CustomerService(Rjp_DatabaseContext _DatabaseContext):base(_DatabaseContext)
        {
            
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
