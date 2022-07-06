using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Models
{
    public class Context : DbContext
    {
        public DbSet<Apartamento> Apartamento { get; set; }
        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Familia> Familia { get; set; }
        public DbSet<Morador> Morador { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
