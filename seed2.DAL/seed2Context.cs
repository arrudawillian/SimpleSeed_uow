using Microsoft.EntityFrameworkCore;
using seed2.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace seed2.DAL
{
    public class seed2Context : DbContext
    {
        public seed2Context(DbContextOptions<seed2Context> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
    }
}
