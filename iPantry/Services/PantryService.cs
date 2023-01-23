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
            var emailExists = await _dataContext.accounts.FirstOrDefaultAsync(a => a.Email == pantry.Email);
            if (emailExists == null)
            {
                _dataContext.accounts.Add(account);
                await _dataContext.SaveChangesAsync();
                return;
            }
        }
    }
}
