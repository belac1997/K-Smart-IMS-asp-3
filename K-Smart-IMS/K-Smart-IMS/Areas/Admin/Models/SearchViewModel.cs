using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace K_Smart_IMS.Models
{
    public class SearchViewModel
    {
        public IEnumerable<Item> Books { get; set; }

        [Required(ErrorMessage = "Please enter a search term.")]
        public string SearchTerm { get; set; }

        public string Type { get; set; }
        public string Header { get; set; }
    }
}
