using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using IDPropertiesEF.Models;

using OficinaModels.Cadastros;
using OficinaModels.Atendimentos;

namespace Capitulo06Migrations.DataAccess
{
    public class DatabaseContext : DbContext
    {
        private readonly string DbPath;
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlite($"Filename={DbPath}");
        }*/
        public DatabaseContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=OficinaMigrations.db");
        }

        public DatabaseContext(string DbPath)
        {
            this.DbPath = DbPath;
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }
    }
}
