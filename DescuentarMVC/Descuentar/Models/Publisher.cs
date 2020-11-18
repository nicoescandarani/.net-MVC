using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Descuentar.Models
{
    public class Publisher
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String password { get; set; }
        [Required]
        public String companyName { get; set; }
    }
}
