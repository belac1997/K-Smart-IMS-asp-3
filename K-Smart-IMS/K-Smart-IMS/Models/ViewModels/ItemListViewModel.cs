using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K_Smart_IMS.Models
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }

        public IEnumerable<Vendor> Vendors { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Dictionary<string, string> Prices =>
            new Dictionary<string, string> {
                { "under15", "Under $15" },
                { "15to30", "$15 to $30" },
                { "over30", "Over $30" }
            };
    }
}
