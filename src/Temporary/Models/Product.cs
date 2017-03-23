using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Temporary.Models
{
    [Table("product")]
    public partial class Product
    {
        [Column("product_id")]
        public int ProductId { get; set; }
        [Required]
        [Column("product_name")]
        [MaxLength(250)]
        public string ProductName { get; set; }
        
    }
}
