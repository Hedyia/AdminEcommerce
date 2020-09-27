using System.Collections.Generic;
using Core.Common;

namespace Core.Entities
{
    public class Category : AuditEntity
    {
        public Category()
        {
            this.Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string DefaultImage { get; set; }
        public bool IsEnabled { get; set; }
        public IList<Product> Products { get; set; }
    }
}