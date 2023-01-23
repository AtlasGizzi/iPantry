namespace iPantry.Models
{
    public class Pantry
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PantryItem> pantryItems { get; set; } = new List<PantryItem>();
    }
}
