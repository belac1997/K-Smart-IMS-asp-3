using System.Collections.Generic;

namespace K_Smart_IMS.Models
{
    public class OrderArchiveModel 
    {
        public IEnumerable<OrderArchive> Orders { get; set; }

        public int OrderArchiveId { get; set; }

        public string OrderList { get; set; }

        public double PriceTotal { get; set; }

        public RouteDictionary ItemGridRoute { get; set; }




    }
}
