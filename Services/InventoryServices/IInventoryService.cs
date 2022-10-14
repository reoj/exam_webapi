
using exam_webapi.Models;

namespace exam_webapi.Services.Inventory
{
    public interface IInventoryService
    {
        InventoryItem GetItem(Guid id);
        IEnumerable<InventoryItem> GetItems();
        void CreateItem (InventoryItem currenItem);
        void UpdateItem (InventoryItem currenItem);
        void DeleteItem (Guid id);
    }
}