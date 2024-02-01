using System.ComponentModel.DataAnnotations;

namespace Canteen.Model
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }

        // Other food item details
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
