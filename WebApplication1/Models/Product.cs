using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ColthColorId { get; set; }
        public int ClothSizeId { get; set; }
        public int PriceRamdomId { get; set; }
        public int ColthTypeId { get; set; }
    }
}