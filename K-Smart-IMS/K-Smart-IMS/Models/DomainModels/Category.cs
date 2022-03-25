using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace K_Smart_IMS.Models
{
    public class Category
    {
        [MaxLength(20 )]
        [Required(ErrorMessage = "Please enter a category id.")]
        [Remote("CheckCategory", "Validation", "Area")]
        public string Id { get; set; } //primary key

        [StringLength(25)]
        [Required(ErrorMessage = "Please enter a Category name.")]
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
