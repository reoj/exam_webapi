using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_webapi.DTOs.ItemDTOs;
using exam_webapi.Models;
using exam_webapi.Services.UserServices;

namespace exam_webapi.Services.Inventory
{
    public class ItemService:IInventoryService
    {
        public List<InventoryItem> _inventory { get; set; }
        private readonly UserService userServices;
        
        public ItemService(UserService userServices)
        {
            this.userServices = userServices;
            _inventory = new List<InventoryItem>();
        }
        public InventoryItem CreateItem(CreateIttemDTO currenItem)
        {
            InventoryItem nw = new InventoryItem(){
                ItemId = new Guid(),
                Name = currenItem.Name,
                Description = currenItem.Description,
                Quantity = currenItem.Quantity,
                UserId = currenItem.UserId,
                Owner = this.userServices.GetUser(currenItem.UserId)
            };
            _inventory.Add(nw);
            return nw;
        }

        public InventoryItem DeleteItem(Guid id)
        {
            var old = _inventory.Where(u => u.ItemId == id).SingleOrDefault();
            _inventory.Remove(old);
            return old;
        }

        public InventoryItem GetItem(Guid id)
        {
            return _inventory.Where(u => u.ItemId == id).SingleOrDefault();
        }

        public InventoryItem UpdateItem(InventoryItem currenItem)
        {
            var old = _inventory.Where(u => u.ItemId == currenItem.ItemId).SingleOrDefault();
            int index = _inventory.IndexOf(old);
            InventoryItem nw = new InventoryItem(){
                ItemId = new Guid(),
                Name = currenItem.Name,
                Description = currenItem.Description,
                Quantity = currenItem.Quantity,
                UserId = currenItem.UserId,
                Owner = this.userServices.GetUser(currenItem.UserId)
            };
            _inventory[index] = nw;
            return nw;
        }
    }
}