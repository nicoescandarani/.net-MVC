using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Descuentar.Models
{
    public class Cupon
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public String companyName { get; set; }
        [Required]
        public double Discount { get; set; }
        [Required]
        public int life { get; set; }
        [Required]
        public int likes { get; set; }
    }
}
