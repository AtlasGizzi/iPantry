using iPantry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace iPantry.Services
{
    public class RecipeService
    {
        private readonly DataContext _dataContext;
        public RecipeService(DataContext context)
        {
            _dataContext= context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Recipe>>> GetAll()
        {
            return await _dataContext.recipes.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Recipe>> AddRecipe(Recipe recipe) 
        {
            var recipeNameExists = await _dataContext.recipes.FirstOrDefaultAsync(r => r.Name == recipe.Name);
            if (recipeNameExists == null)
            {
                _dataContext.recipes.Add(recipe);
                await _dataContext.SaveChangesAsync();
                return recipe;
            }
            throw new Exception("Recipe name already exists.");
        }
    }
}
