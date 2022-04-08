using Newtonsoft.Json;

namespace K_Smart_IMS.Models
{
    //this entire class is basically a meme, it is just an item with a new variable called quantity
    public class CartItem
    {
        public ItemDTO Item { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double Subtotal => Item.Price * Quantity;
    }
}
