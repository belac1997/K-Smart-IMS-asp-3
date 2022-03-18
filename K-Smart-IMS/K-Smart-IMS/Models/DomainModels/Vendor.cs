using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace K_Smart_IMS.Models
{
    public class Vendor
    {
        public int Id { get; set; } //primary key

        [Required(ErrorMessage = "Please enter a vendor name.")]
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<ItemVendor> ItemVendors { get; set; }
    }
}
