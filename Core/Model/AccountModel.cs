using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class AccountModel
    {
        [Required(ErrorMessage = "Customer ID is required.")]
        public int AccountId { get; set; }
        [Required(ErrorMessage = "Initial balance is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Initial balance must be greater than or equal to 0.")]
        public double? Balance { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
    }
}
