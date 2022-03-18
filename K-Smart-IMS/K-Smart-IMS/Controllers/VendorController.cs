using Microsoft.AspNetCore.Mvc;
using K_Smart_IMS.Models;

namespace K_Smart_IMS.Controllers
{
    public class VendorController : Controller
    {
        private Repository<Vendor> data { get; set; }
        public VendorController(InventoryContext ctx) => data = new Repository<Vendor>(ctx);

        public IActionResult Index() => RedirectToAction("List");

        public ViewResult List(GridDTO vals)
        {
            string defaultSort = nameof(Vendor.Name);
            var builder = new GridBuilder(HttpContext.Session, vals, defaultSort);
            builder.SaveRouteSegments();

            var options = new QueryOptions<Vendor>
            {
                Include = "ItemVendors.Item",
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
                OrderByDirection = builder.CurrentRoute.SortDirection
            };
            if (builder.CurrentRoute.SortField.EqualsNoCase(defaultSort))
                options.OrderBy = a => a.Name;
            else
                options.OrderBy = a => a.Name;

            var vm = new VendorListViewModel
            {
                Vendors = data.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Count)
            };

            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var Vendor = data.Get(new QueryOptions<Vendor>
            {
                Include = "ItemVendors.Item",
                Where = a => a.Id == id
            });
            return View(Vendor);
        }
    }
}