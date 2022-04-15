using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace K_Smart_IMS.Models
{
    public class Validate
    {
        private const string CategoryKey = "validCategory";
        private const string VendorKey = "validVendor";
        private const string EmailKey = "validEmail";

        private ITempDataDictionary tempData { get; set; }
        public Validate(ITempDataDictionary temp) => tempData = temp;

        public bool IsValid { get; private set; }
        public string ErrorMessage { get; private set; }

        public void CheckCategory(string CategoryId, Repository<Category> data)
        {
            Category entity = data.Get(CategoryId);
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" : 
                $"Category id {CategoryId} is already in the database.";
        }
        public void MarkCategoryChecked() => tempData[CategoryKey] = true;
        public void ClearCategory() => tempData.Remove(CategoryKey);
        public bool IsCategoryChecked => tempData.Keys.Contains(CategoryKey);

        public void CheckVendor(string Name, string operation, Repository<Vendor> data)
        {
            Vendor entity = null; 
            if (Operation.IsAdd(operation)) {
                entity = data.Get(new QueryOptions<Vendor> {
                    Where = a => a.Name == Name });
            }
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" : 
                $"Vendor {entity.Name} is already in the database.";
        }
        public void MarkVendorChecked() => tempData[VendorKey] = true;
        public void ClearVendor() => tempData.Remove(VendorKey);
        public bool IsVendorChecked => tempData.Keys.Contains(VendorKey);
    }
}
