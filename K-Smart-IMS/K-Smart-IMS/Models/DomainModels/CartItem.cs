using Newtonsoft.Json;

namespace K_Smart_IMS.Models
{
    public class CartItem
    {
        public ItemDTO Item { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double Subtotal => Item.Price * Quantity;
    }
}
