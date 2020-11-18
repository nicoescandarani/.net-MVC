using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Descuentar.Models
{
    public class Context : DbContext
    {

        public Context()
        {
        }

        public Context (DbContextOptions<Context> options) : base(options)
        {
        }

        public virtual DbSet<Cupon> cupons { get; set; }
        public virtual DbSet<Publisher> publishers { get; set; }
        public virtual DbSet<User> users { get; set; }
    }
}
