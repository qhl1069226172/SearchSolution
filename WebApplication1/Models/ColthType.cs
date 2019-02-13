using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ColthType")]
    public class ColthType
    {
        [Key]
        public int ColthTypeId { get; set; }
        public string ColthTypeName { get; set; }
    }
}