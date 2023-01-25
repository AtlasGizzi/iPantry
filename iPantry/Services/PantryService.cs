using iPantry.Models;
using Microsoft.EntityFrameworkCore;

namespace iPantry.Services
{
    public class PantryService
    {
        private readonly DataContext _dataContext;

        public PantryService(DataContext dataContext)
        {
            _dataContext= dataContext;
        }

        public async Task CreatePantry(Pantry pantry)
        {
            var pantryExists = await _dataContext.pantries.FirstOrDefaultAsync(a=>a.Name == pantry.Name);
            if (pantryExists == null)
            {
                _dataContext.pantries.Add(pantry);
                await _dataContext.SaveChangesAsync();
                return;
            }
            throw new Exception("Pantry already exists.");
        }
        public async Task<Pantry> GetPantryById(int id)
        {
            var pantry = await _dataContext.pantries.FindAsync(id);
            if (pantry == null )
            {
                throw new Exception("Pantry not found");
            }
            return pantry;
        }
    }
}
