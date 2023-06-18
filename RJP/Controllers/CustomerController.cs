using Core.Interface;
using Core.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace RJP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger,ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _logger = logger;

        }

        [HttpGet("{id}")]

        public UserAccountModel Get(int id)
        {

            return _customerRepository.GetCustomer(id);
        }
        [HttpGet]
        public IEnumerable<CustomerModel> All()
        {
            return _customerRepository.GetAll();
        }
    }
}
