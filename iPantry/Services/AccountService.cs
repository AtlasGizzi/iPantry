using iPantry.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;



namespace iPantry.Services
{
    public class AccountService : IAccountService
    {
       private readonly DataContext _dataContext;

        public AccountService(DataContext dataContext)
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
        public async Task<List<Account>> GetAll()
            
        { 
             return await _dataContext.accounts.ToListAsync();

        }
        
    }
}
