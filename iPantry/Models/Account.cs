namespace iPantry.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<Recipe> recipes { get; set; } = new();
        public List<Pantry> pantries { get; set; } = new();
        
    }
}
