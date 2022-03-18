using System.Linq;

namespace K_Smart_IMS.Models
{
    public class InventoryUnitOfWork : IInventoryUnitOfWork
    {
        private InventoryContext context { get; set; }
        public InventoryUnitOfWork(InventoryContext ctx) => context = ctx;

        private Repository<Item> ItemData;
        public Repository<Item> Items {
            get {
                if (ItemData == null)
                    ItemData = new Repository<Item>(context);
                return ItemData;
            }
        }

        private Repository<Vendor> VendorData;
        public Repository<Vendor> Vendors {
            get {
                if (VendorData == null)
                    VendorData = new Repository<Vendor>(context);
                return VendorData;
            }
        }

        private Repository<ItemVendor> ItemVendorData;
        public Repository<ItemVendor> ItemVendors {
            get {
                if (ItemVendorData == null)
                    ItemVendorData = new Repository<ItemVendor>(context);
                return ItemVendorData;
            }
        }

        private Repository<Category> CategoryData;
        public Repository<Category> Categories
        {
            get {
                if (CategoryData == null)
                    CategoryData = new Repository<Category>(context);
                return CategoryData;
            }
        }

        public void DeleteCurrentItemVendors(Item Item)
        {
            var currentVendors = ItemVendors.List(new QueryOptions<ItemVendor> {
                Where = ba => ba.ItemId == Item.Id
            });
            foreach (ItemVendor ba in currentVendors) {
                ItemVendors.Delete(ba);
            }
        }

        public void LoadNewItemVendors(Item Item, int[] Vendorids)
        {
            Item.ItemVendors = Vendorids.Select(i =>
                new ItemVendor { Item = Item, VendorId = i })
                .ToList();
        }

        public void Save() => context.SaveChanges();
    }
}