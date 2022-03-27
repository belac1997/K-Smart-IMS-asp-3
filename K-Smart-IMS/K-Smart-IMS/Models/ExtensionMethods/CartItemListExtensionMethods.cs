using System.Linq;
using System.Collections.Generic;


namespace K_Smart_IMS.Models
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list) =>
            list.Select(ci => new CartItemDTO {
                Id = ci.Item.Id,
                Quantity = ci.Quantity
            }).ToList();
        
    }
}
