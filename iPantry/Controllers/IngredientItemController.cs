using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using iPantry.Services;
using iPantry.Models;

namespace iPantry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientItemController : ControllerBase
    {
        private readonly IngredientItemService _ingredientItemService;
        public IngredientItemController(IngredientItemService ingredientItemService)
        {
            this._ingredientItemService= ingredientItemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<IngredientItem>>> GetIngredientItem()
        {
            return Ok(await _ingredientItemService.GetIngredientItem()) ;
        }
    }
}
