using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ClothSize")]

    public class ClothSize
    {
        [Key]
        public int ClothSizeId { get; set; }
        public string ClothSizeName { get; set; }
    }
}