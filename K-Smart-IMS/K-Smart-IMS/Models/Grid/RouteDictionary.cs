using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace K_Smart_IMS.Models
{
    public static class FilterPrefix
    {
        public const string Category = "category-";
        public const string Price = "price-";
        public const string Vendor = "vendor-";
    }

    public class RouteDictionary : Dictionary<string, string>
    {
        public int PageNumber
        {
            get => Int32.Parse(Get(nameof(GridDTO.PageNumber)));
            set => this[nameof(GridDTO.PageNumber)] = value.ToString();
        }

        public int PageSize
        {
            get => Int32.Parse(Get(nameof(GridDTO.PageSize)));
            set => this[nameof(GridDTO.PageSize)] = value.ToString();
        }

        public string SortField
        {
            get => Get(nameof(GridDTO.SortField));
            set => this[nameof(GridDTO.SortField)] = value;
        }

        public string SortDirection
        {
            get => Get(nameof(GridDTO.SortDirection));
            set => this[nameof(GridDTO.SortDirection)] = value;
        }

        public void SetSortAndDirection(string fieldName, RouteDictionary current)
        {
            this[nameof(GridDTO.SortField)] = fieldName;

            if (current.SortField.Equals(fieldName) &&
                current.SortDirection == "asc")
                this[nameof(GridDTO.SortDirection)] = "desc";
            else
                this[nameof(GridDTO.SortDirection)] = "asc";
        }

        public string CategoryFilter
        {
            get => Get(nameof(ItemsGridDTO.Category))?.Replace(FilterPrefix.Category, "");
            set => this[nameof(ItemsGridDTO.Category)] = value;
        }

        public string PriceFilter
        {
            get => Get(nameof(ItemsGridDTO.Price))?.Replace(FilterPrefix.Price, "");
            set => this[nameof(ItemsGridDTO.Price)] = value;
        }

        public string VendorFilter
        {
            get
            {
                string s = Get(nameof(ItemsGridDTO.Vendor))?.Replace(FilterPrefix.Vendor, "");
                int index = s?.IndexOf('-') ?? -1;
                return (index == -1) ? s : s.Substring(0, index);
            }
            set => this[nameof(ItemsGridDTO.Vendor)] = value;
        }

        public void ClearFilters() =>
            CategoryFilter = PriceFilter = VendorFilter = ItemsGridDTO.DefaultFilter;

        private string Get(string key) => Keys.Contains(key) ? this[key] : null;

        public RouteDictionary Clone()
        {
            var clone = new RouteDictionary();
            foreach (var key in Keys)
            {
                clone.Add(key, this[key]);
            }
            return clone;
        }
    }
}
