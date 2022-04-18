using System.Collections.Generic;

namespace K_Smart_IMS.Models
{
    public class CartViewModel 
    {
        public IEnumerable<CartItem> List { get; set; }
        public double Subtotal { get; set; }
        public RouteDictionary ItemGridRoute { get; set; }

    }
}
