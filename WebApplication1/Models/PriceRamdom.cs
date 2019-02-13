using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("PriceRamdom")]
    public class PriceRamdom
    {
        [Key]
        public int PriceRamdomId { get; set; }
        public string PriceRamdomName { get; set; }
    }
}