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
                { "under7", "Under $7" },
                { "7to14", "$7 to $14" },
                { "over14", "Over $14" }
            };
    }
}
