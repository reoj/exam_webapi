using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_webapi.DTOs.ItemDTOs;
using exam_webapi.Models;

namespace exam_webapi.Services.Inventory
{
    public class ItemService:IInventoryService
    {
        public List<InventoryItem> _inventory { get; set; }
        public ItemService()
        {
            _inventory = new List<InventoryItem>();
        }
        public InventoryItem CreateItem(CreateIttemDTO currenItem)
        {
            InventoryItem nw = new InventoryItem(){
                ItemId = new Guid(),
                Name = currenItem.Name,

            };
            _inventory.Add(nw);
            return nw;
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public InventoryItem GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(InventoryItem currenItem)
        {
            throw new NotImplementedException();
        }
    }
}