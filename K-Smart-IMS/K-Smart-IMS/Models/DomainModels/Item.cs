using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace K_Smart_IMS.Models
{
    public partial class Item
    {
        public int Id { get; set; } //primary key

        [Required(ErrorMessage = "Please enter a name for the item.")]
        [StringLength(200)]
        public string Name { get; set; }

        public int Qty { get; set; }

        [Range(0.0, 1000000.0, ErrorMessage = "Price must be more than 0.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<ItemVendor> ItemVendors { get; set; }
    }
}
