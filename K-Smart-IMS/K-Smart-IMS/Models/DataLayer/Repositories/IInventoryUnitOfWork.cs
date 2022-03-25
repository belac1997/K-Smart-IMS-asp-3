namespace K_Smart_IMS.Models
{
    public interface IInventoryUnitOfWork
    {
        Repository<Item> Items { get; }
        Repository<Vendor> Vendors { get; }
        Repository<ItemVendor> ItemVendors { get; }
        Repository<Category> Categories { get; }

        void DeleteCurrentItemVendors(Item Item);
        void LoadNewItemVendors(Item Item, int[] Vendorids);
        void Save();
    }
}
