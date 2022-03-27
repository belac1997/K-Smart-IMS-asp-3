using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using K_Smart_IMS.Models;

namespace K_Smart_IMS.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private Repository<Item> data { get; set; }
        public CartController(InventoryContext ctx) => data = new Repository<Item>(ctx);


        private Cart GetCart()
        {
            var cart = new Cart(HttpContext);
            cart.Load(data);
            return cart;
        }

        public ViewResult Index() 
        {
            var cart = GetCart();
            var builder = new ItemsGridBuilder(HttpContext.Session);

            var vm = new CartViewModel {
                List = cart.List,
                Subtotal = cart.Subtotal,
                ItemGridRoute = builder.CurrentRoute
            };
            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Add(int id)
        {
            var Item = data.Get(new QueryOptions<Item> {
                Include = "ItemVendors.Vendor, Category",
                Where = b => b.Id == id
            });
            if (Item == null){
                TempData["message"] = "Unable to add item to the cart.";   
            }
            else {
                var dto = new ItemDTO();
                dto.Load(Item);
                CartItem item = new CartItem {
                    Item = dto,
                    Quantity = 1  
                };

                Cart cart = GetCart();
                cart.Add(item);
                cart.Save();

                TempData["message"] = $"{Item.Name} was added to the cart";
            }

            var builder = new ItemsGridBuilder(HttpContext.Session);
            return RedirectToAction("List", "Item", builder.CurrentRoute);
        }

        [HttpPost]
        public RedirectToActionResult Remove(int id)
        {
            Cart cart = GetCart();
            CartItem item = cart.GetById(id);
            cart.Remove(item);
            cart.Save();

            TempData["message"] = $"{item.Item.Name} was removed from cart.";
            return RedirectToAction("Index");
        }
                
        [HttpPost]
        public RedirectToActionResult Clear()
        {
            Cart cart = GetCart();
            cart.Clear();
            cart.Save();

            TempData["message"] = "Cart cleared!";
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            Cart cart = GetCart();
            CartItem item = cart.GetById(id);
            if (item == null)
            {
                TempData["message"] = "Sorry, we're unable to locate your cart item.";
                return RedirectToAction("List");
            }
            else
            {
                return View(item);
            }
        }

        [HttpPost]
        public RedirectToActionResult Edit(CartItem i)
        {
            Cart cart = GetCart();
            cart.Edit(i);
            cart.Save();

            TempData["message"] = $"{i.Item.Name} has been updated";
            return RedirectToAction("Index");
        }

        public ViewResult Checkout() => View();
    }
}