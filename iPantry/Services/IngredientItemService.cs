using System.Net.Http.Headers;
using iPantry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace iPantry.Services
{
    public class IngredientItemService
    {
        private readonly DataContext _dataContext;
        public IngredientItemService(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<List<IngredientItem>> GetIngredientItem()
        {
            return await _dataContext.ingredientItems.ToListAsync();
        }
       
    }
}
