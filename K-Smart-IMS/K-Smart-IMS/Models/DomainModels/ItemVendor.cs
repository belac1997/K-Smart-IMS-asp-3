using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K_Smart_IMS.Models
{
    public class ItemVendor
    {
        public int ItemId { get; set; }
        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }
        public Item Item { get; set; }
    }
}
