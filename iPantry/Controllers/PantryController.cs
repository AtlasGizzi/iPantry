using iPantry.Models;
using iPantry.Services;
using Microsoft.AspNetCore.Mvc;



namespace iPantry.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
        public class PantryController : ControllerBase
        {
            private readonly PantryService _pantryService;
            public PantryController(PantryService pantryService)
            {
                _pantryService = pantryService;
            }

            [HttpPost]
            public async Task<ActionResult> CreatePantry(Pantry pantry)
            {
                await _pantryService.CreatePantry(pantry);
                return Ok();
            }
            [HttpGet("{id}")]
            public async Task<ActionResult<Pantry>> GetPantryById(int id)
            {
            return Ok(await _pantryService.GetPantryById(id));
            }

        }
    
}
