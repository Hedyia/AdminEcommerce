namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal TotalReviewCount { get; set; }
        public decimal ReviewValue { get; set; }
        public string Images { get; set; }
        public string DefaultImage { get; set; }
        public int Status { get; set; }
        
        //Seller
        public int SellerId { get; set; }
        
    }
}