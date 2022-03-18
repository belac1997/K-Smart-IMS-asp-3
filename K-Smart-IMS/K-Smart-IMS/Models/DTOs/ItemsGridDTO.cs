using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace K_Smart_IMS.Models
{
    public class ItemsGridDTO : GridDTO
    {
        [JsonIgnore]
        public const string DefaultFilter = "all";

        public string Vendor { get; set; } = DefaultFilter;
        public string Category { get; set; } = DefaultFilter;
        public string Price { get; set; } = DefaultFilter;
    }

}