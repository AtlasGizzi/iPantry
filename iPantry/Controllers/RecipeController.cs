using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using iPantry.Models;

namespace iPantry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : Controller
    {
        private readonly DataContext _dataContext;
        public RecipeController(DataContext context) 
        {
            _dataContext= context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Recipe>>> GetAll()
        {
            return Ok(await _dataContext.recipes.ToListAsync());
        }
    }
}

