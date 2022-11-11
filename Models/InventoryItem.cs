using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam_webapi.Models
{
    public class InventoryItem
    {
        public Guid ItemId { get; set; } = new Guid();
        public string Name { get; set; } = "Out of Stock";
        public string Description { get; set; } = "";
        public int Quantity { get; set; }
        public User Owner { get; set; }
        public int UserId { get; set; }
    }
}