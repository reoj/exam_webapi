using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_webapi.Models;

namespace exam_webapi.Repositories
{
    public class InventoryRepository
    {
        public InventoryRepository()
        {
            List<InventoryItem> _inventory = new(){
                new InventoryItem(){
                    ItemId = new Guid(),
                    
                }
            };
        }
        
    }
}