using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Canteen.Model
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int Balance { get; set; }
    }
}
