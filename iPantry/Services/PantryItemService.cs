using iPantry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iPantry.Services
{
    public class PantryItemService
    {
        private readonly DataContext _dataContext;


        public PantryItemService(DataContext dataContext)
        {
            _dataContext= dataContext;
        }

        public async Task<ActionResult<PantryItem>> GetPantryItem(int id)
        {
            return await _dataContext.pantryItems.FindAsync(id);
        }
      
        public async Task<ActionResult<List<PantryItem>>> GetAll()
        {
            return await _dataContext.pantryItems.ToListAsync();
        }
       
        public async Task<ActionResult<List<PantryItem>>> AddNewPantryItem(PantryItem pantryItem)
        {
            _dataContext.pantryItems.Add(pantryItem);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.pantryItems.ToListAsync();

        }
       
        public async Task<ActionResult<List<PantryItem>>> DeletePantryItem(int id)
        {
            var dbpantryitem = await _dataContext.pantryItems.FindAsync(id);
            

            _dataContext.pantryItems.Remove(dbpantryitem);
            await _dataContext.SaveChangesAsync();
            return await _dataContext.pantryItems.ToListAsync();

        }
    
        public async Task<ActionResult<List<PantryItem>>> EditPantryItem(int id, PantryItem request)
        {
            var dbPantryItem = await _dataContext.pantryItems.FindAsync(request.Id);
           

            dbPantryItem.Id = request.Id;
            dbPantryItem.Name = request.Name;
            dbPantryItem.Weight = request.Weight;
            dbPantryItem.Calories = request.Calories;

            await _dataContext.SaveChangesAsync();

            return await _dataContext.pantryItems.ToListAsync();
        }

    }
}
