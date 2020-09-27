using System;
using Core.Common;

namespace Core.Entities
{
    public class Product : AuditEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReviewCount { get; set; }
        public decimal ReviewValue { get; set; }
        public string Images { get; set; }
        public string DefaultImage { get; set; }
        public bool Status { get; set; }
        public DateTime ArrivedDate { get; set; }
        public bool IsRecentrlyArrived { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}