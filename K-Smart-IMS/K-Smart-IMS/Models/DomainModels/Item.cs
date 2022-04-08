using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//we should probably add a quantity of this particular item to this class. Or maybe we create an entirely separate inventory class

namespace K_Smart_IMS.Models
{
    public partial class Item
    {
        public int Id { get; set; } //primary key

        //I don't think we'll have any logic for creating items by an admin but this is nice if we did
        [Required(ErrorMessage = "Please enter a name for the item.")]
        [StringLength(200)]
        public string Name { get; set; }

        [Range(0.0, 1000000.0, ErrorMessage = "Price must be more than 0.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<ItemVendor> ItemVendors { get; set; }
    }
}
