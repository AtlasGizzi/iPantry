using System.ComponentModel.DataAnnotations.Schema;

namespace iPantry.Models
{
    [Table ("PantryItems")]
    public class PantryItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Calories { get; set; }
    }
}
