using iPantry.Models;

namespace iPantry.Services
{
    public interface IAccountService
    {
        Task Register(Account account);
        Task<List<Account>> GetAll();
    }
}
