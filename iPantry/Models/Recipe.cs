namespace iPantry.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public List<IngredientItem> Item { get; set; } // every recipe has a list of ingredients
        public string Instruction { get; set; } = string.Empty; //every recipe has writen instructions
    }
}
