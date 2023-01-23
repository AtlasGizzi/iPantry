using iPantry.Models;
using Microsoft.EntityFrameworkCore;

namespace iPantry.Services
{
    public class AccountService
    {
        private readonly DataContext _dataContext;
        
        public AccountService (DataContext dataContext) 
        { 
            _dataContext= dataContext;
        }

        public async Task Register(Account account) 
        { 
            var emailExists = await _dataContext.accounts.FirstOrDefaultAsync(a => a.Email == account.Email);
            if (emailExists == null) 
            { 
                _dataContext.accounts.Add(account);
                await _dataContext.SaveChangesAsync();
                return;
            }
        }
    }
}
