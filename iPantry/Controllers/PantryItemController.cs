using Microsoft.AspNetCore.Mvc;
using iPantry.Models;
using Microsoft.EntityFrameworkCore;
using iPantry.Services;

namespace iPantry.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    
    public class PantryItemController : ControllerBase
    {   
        private readonly PantryItemService _pantryItemService;

        
        public PantryItemController(PantryItemService pantryItemService) 
        {
            _pantryItemService= pantryItemService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PantryItem>> GetPantryItem(int id)
        {
            try
            {
                return Ok(await _pantryItemService.GetPantryItem(id));
            }
            catch (Exception ex) 
            {
                return NotFound("Pantry item not found.");
            };
        }
        [HttpGet]
        public async Task<ActionResult<List<PantryItem>>> GetAll()
        {
            return Ok(await _pantryItemService.GetAll());
        }
        [HttpPost]
        public async Task<ActionResult<List<PantryItem>>> AddNewPantryItem(PantryItem pantryItem) 
        {
            return Ok(await _pantryItemService.AddNewPantryItem(pantryItem));
             

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PantryItem>>> DeletePantryItem(int id) 
        {
            try
            {
                await _pantryItemService.DeletePantryItem(id);
                return Ok();
            }
            catch (Exception) 
            {
                return NotFound("Pantry item not found.");
            }

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<PantryItem>> EditPantryItem(int id, PantryItem request)
        {
            try
            {
                await _pantryItemService.EditPantryItem(id, request);
                return Ok();
            }

            catch (Exception)
            {
                return NotFound("Pantry Item not found.");
            }
        }    
    }
}
