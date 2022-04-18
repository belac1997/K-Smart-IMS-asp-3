using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//we should probably add a quantity of this particular item to this class. Or maybe we create an entirely separate inventory class

namespace K_Smart_IMS.Models
{
    public partial class OrderArchive
    {
        public int OrderArchiveId { get; set; } //primary key

        public string OrderList { get; set; }

        public double PriceTotal { get; set; }
    }
}
