using Core.Model;

namespace Core.Entities
{
    public partial class Customer
    {
        public static implicit operator CustomerModel(Customer customer)
        {

            CustomerModel customerDto = new CustomerModel();
            customerDto.CustomerId = (int)customer?.CustomerId;
            customerDto.FirstName = customer?.FirstName;
            customerDto.LastName = customer?.LastName;
            return customerDto;
        }

        public static implicit operator Customer(CustomerModel customerModel)
        {

            Customer customer = new Customer();
            customer.CustomerId = (int)customerModel?.CustomerId;
            customer.FirstName = customerModel?.FirstName;
            customer.LastName = customerModel?.LastName;
            return customer;
        }
    }
}
