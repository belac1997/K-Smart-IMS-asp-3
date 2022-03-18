using System;
using System.Linq;

namespace K_Smart_IMS.Models
{
    public class ItemQueryOptions : QueryOptions<Item>
    {
        public void SortFilter(ItemsGridBuilder builder)
        {
            if (builder.IsFilterByCategory) {
                Where = b => b.CategoryId == builder.CurrentRoute.CategoryFilter;
            }
            if (builder.IsFilterByPrice) {
                if (builder.CurrentRoute.PriceFilter == "under7")
                    Where = b => b.Price < 7;
                else if (builder.CurrentRoute.PriceFilter == "7to14")
                    Where = b => b.Price >= 7 && b.Price <= 14;
                else
                    Where = b => b.Price > 14;
            }
            if (builder.IsFilterByVendor) {
                int id = Int32.Parse(builder.CurrentRoute.VendorFilter);
                if (id > 0)
                    Where = b => b.ItemVendors.Any(ba => ba.Vendor.Id == id);
            }

            if (builder.IsSortByCategory) {
                OrderBy = b => b.Category.Name;
            }
            else if (builder.IsSortByPrice) {
                OrderBy = b => b.Price;
            }
            else  {
                OrderBy = b => b.Name;
            }
        }
    }
}
