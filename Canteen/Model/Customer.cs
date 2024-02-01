using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Canteen.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        // Other customer details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<OrderDetails> Orders { get; set; }
    }
}
