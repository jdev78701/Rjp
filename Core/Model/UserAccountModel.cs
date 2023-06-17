using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class UserAccountModel
    {
        public CustomerModel customerModel { get; set; }
        public ArrayList accountTrancationModels { get; set; } = new ArrayList();
    }
}
