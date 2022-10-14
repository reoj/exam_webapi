using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_webapi.Models;

namespace exam_webapi.Repositories
{
    public class InventoryRepository
    {
        public List<InventoryItem> _inventory { get; set; }
        public InventoryRepository()
        {
            _inventory = new List<InventoryItem>();
        }
        
    }
}