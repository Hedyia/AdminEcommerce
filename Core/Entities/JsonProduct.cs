using System.Collections.Generic;

namespace Core.Entities
{
    public class  MainProduct 
    {
        public MainProduct()
        {
            Products = new List<JsonProduct>();
        }
        public List<JsonProduct> Products { get; set; }
    }
    public class JsonProduct
    {
        public JsonProduct()
        {
            Variations = new List<Variation>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Variation> Variations { get; set; }
    }
    public class Variation 
    {
        public Variation()
        {
            Value = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Value { get; set; }
    }
}