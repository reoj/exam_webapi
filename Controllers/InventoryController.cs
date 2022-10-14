using exam_webapi.Repositories;
using exam_webapi.Services.Inventory;
using exam_webapi.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace exam_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController:ControllerBase
    {
        private readonly IInventoryService _inventory;
        
        public InventoryController(IInventoryService inventory)
        {
            this._inventory = inventory;            
        }

        // [HttpGet]
        // [HttpPost]
        // [HttpPut("{id}")]
        // [HttpDelete("{id}")]
    }
}