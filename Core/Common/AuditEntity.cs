using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Common
{
    public class AuditEntity
    {
        [MaxLength(450)]
        public string CreatedBy { get; set; }
 
        public DateTime Created { get; set; }
        
        [MaxLength(450)]
        public string LastModifiedBy { get; set; }
 
        public DateTime? LastModified { get; set; }
    }
}