using Microsoft.EntityFrameworkCore;

using iPantry.Models;
namespace iPantry
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Account> accounts { get; set; } //create a database table using the Account Model and call it "accounts"
        public DbSet<Recipe> recipes { get; set; }
        public DbSet<PantryItem> pantryItems { get; set; }
        public DbSet<IngredientItem> ingredientItems { get; set;}

    }
}
