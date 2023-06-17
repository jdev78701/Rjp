using Core.Interface;
using Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountRepository _accountRepository;
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger, IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _logger = logger;
        
        }
        [HttpPost]
        public AccountModel Save(AccountModel accountModel)
        {
            var accountModelSaved= _accountRepository.Add(accountModel);
            if (accountModelSaved != null)
                return accountModelSaved;
            else return null;
        }
    }
}
