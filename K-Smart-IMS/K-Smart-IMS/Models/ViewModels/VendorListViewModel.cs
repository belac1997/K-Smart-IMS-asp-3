using System.Collections.Generic;

namespace K_Smart_IMS.Models
{
    public class VendorListViewModel
    {
        public IEnumerable<Vendor> Vendors { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
    }
}
