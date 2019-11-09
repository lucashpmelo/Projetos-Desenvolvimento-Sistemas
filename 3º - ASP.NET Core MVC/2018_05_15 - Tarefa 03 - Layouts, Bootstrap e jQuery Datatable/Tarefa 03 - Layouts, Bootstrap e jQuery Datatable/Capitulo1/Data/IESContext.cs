using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capitulo1.Models;

namespace Capitulo1.Data
{
    public class IESContext : DbContext
    {
        public IESContext (DbContextOptions<IESContext>options) : base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
                
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
        }
                
        public DbSet<Capitulo1.Models.Instituicao> Instituicao { get; set; }
    }
}
