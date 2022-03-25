using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace K_Smart_IMS.Models
{
    public class ItemsGridBuilder : GridBuilder
    {
        public ItemsGridBuilder(ISession sess) : base(sess) { }

        public ItemsGridBuilder(ISession sess, ItemsGridDTO values,
            string defaultSortField) : base(sess, values, defaultSortField)
        {
            bool isInitial = values.Category.IndexOf(FilterPrefix.Category) == -1;
            routes.VendorFilter = (isInitial) ? FilterPrefix.Vendor + values.Vendor : values.Vendor;
            routes.CategoryFilter = (isInitial) ? FilterPrefix.Category + values.Category : values.Category;
            routes.PriceFilter = (isInitial) ? FilterPrefix.Price + values.Price : values.Price;
        }

        public void LoadFilterSegments(string[] filter, Vendor Vendor)
        {
            if (Vendor == null)
            {
                routes.VendorFilter = FilterPrefix.Vendor + filter[0];
            }
            else
            {
                routes.VendorFilter = FilterPrefix.Vendor + filter[0]
                    + "-"; //+ Vendor.Name.Slug();
            }
            routes.CategoryFilter = FilterPrefix.Category + filter[1];
            routes.PriceFilter = FilterPrefix.Price + filter[2];
        }

        public void ClearFilterSegments() => routes.ClearFilters();

        string def = ItemsGridDTO.DefaultFilter;
        public bool IsFilterByVendor => routes.VendorFilter != def;
        public bool IsFilterByCategory => routes.CategoryFilter != def;
        public bool IsFilterByPrice => routes.PriceFilter != def;

        public bool IsSortByCategory =>
            routes.SortField.Equals(nameof(Category));
        public bool IsSortByPrice =>
            routes.SortField.Equals(nameof(Item.Price));
    }
}
