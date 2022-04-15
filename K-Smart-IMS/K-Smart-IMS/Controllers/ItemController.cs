using Microsoft.AspNetCore.Mvc;
using K_Smart_IMS.Models;

namespace K_Smart_IMS.Controllers
{
    public class ItemController : Controller
    {
        private InventoryUnitOfWork data { get; set; }
        public ItemController(InventoryContext ctx) => data = new InventoryUnitOfWork(ctx);

        public RedirectToActionResult Index() => RedirectToAction("List");

        public ViewResult List(ItemsGridDTO values)
        {
            var builder = new ItemsGridBuilder(HttpContext.Session, values, 
                defaultSortField: nameof(Item.Name));

            var options = new ItemQueryOptions {
                Include = "ItemVendors.Vendor, Category",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder);

            var vm = new ItemListViewModel {
                Items = data.Items.List(options),
                Vendors = data.Vendors.List(new QueryOptions<Vendor> {
                    OrderBy = a => a.Name }),
                Categories = data.Categories.List(new QueryOptions<Category> {
                    OrderBy = g => g.Name }),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Items.Count)
            };

            return View(vm);
        }

        public ViewResult Details(int id)
        {
            var Item = data.Items.Get(new QueryOptions<Item> {
                Include = "ItemVendors.Vendor, Category",
                Where = b => b.Id == id
            });
            return View(Item);
        }

        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            var builder = new ItemsGridBuilder(HttpContext.Session);

            if (clear) {
                builder.ClearFilterSegments();
            }
            else {
                var Vendor = data.Vendors.Get(filter[0].ToInt());
                builder.LoadFilterSegments(filter, Vendor);
            }

            builder.SaveRouteSegments();
            return RedirectToAction("List", builder.CurrentRoute);
        }

        [HttpPost]
        public RedirectToActionResult AddOne(int id)
        { //This method increases an item's inventory count by one
            var Item = data.Items.Get(new QueryOptions<Item>
            {
                Where = b => b.Id == id
            });
            Item.Qty += 1;
            data.Save();
            return RedirectToAction("Details", Item);
        }

        [HttpPost]
        public RedirectToActionResult MinusOne(int id)
        {  //This method decreases an item's inventory count by one
            var Item = data.Items.Get(new QueryOptions<Item>
            {
                Where = b => b.Id == id
            });
            if (Item.Qty > 0)
            {
                Item.Qty -= 1;
                data.Save();
            }
            return RedirectToAction("Details", Item);
        }
    }   
} 