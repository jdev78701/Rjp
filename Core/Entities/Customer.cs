using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
