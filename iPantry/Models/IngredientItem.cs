using System.Text.Json.Serialization;
namespace iPantry.Models
{
    public class IngredientItem //: IngredientItemBase Not sure if I need this
    {
        //public virtual Recipe recipe {get; set;} I think this line may actually be redundent. every ingredient it connected to at least one recipe or more
        public virtual int id { get; set;}
        public virtual string name { get; set;} = string.Empty;
        public virtual int weight { get; set;} 
    }
}
