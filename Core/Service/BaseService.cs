using Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class BaseService
    {
        protected readonly Rjp_DatabaseContext _DatabaseContext;
        public BaseService(Rjp_DatabaseContext dbContext)
        {
            _DatabaseContext = dbContext;
        }
    }
}
