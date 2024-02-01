using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Canteen.Model
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        // Other vendor details
        public string VendorName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public List<OrderDetails> Orders { get; set; }
    }
}
