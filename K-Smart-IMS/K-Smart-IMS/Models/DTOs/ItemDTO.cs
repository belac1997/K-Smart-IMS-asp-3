using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K_Smart_IMS.Models
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Dictionary<int, string> Vendors { get; set; }

        public void Load(Item item)
        {
            Id = item.Id;
            Name = item.Name;
            Price = item.Price;
            Vendors = new Dictionary<int, string>();
            foreach (ItemVendor v in item.ItemVendors)
            {
                Vendors.Add(v.Vendor.Id, v.Vendor.Name);
            }
        }
    }
}
