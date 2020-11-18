using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Descuentar.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String name { get; set; }
        [Required]
        public String password { get; set; }
        [Required]
        public String email { get; set; }
    }
}
