using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ColthColor")]
    public class ColthColor
    {
        [Key]
        public int ColthColorId { get; set; }
        public string ColthColorName { get; set; }
    }
}