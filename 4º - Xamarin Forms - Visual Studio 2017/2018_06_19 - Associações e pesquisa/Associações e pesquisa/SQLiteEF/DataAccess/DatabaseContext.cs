using Microsoft.EntityFrameworkCore;
using IDPropertiesEF.Models;

using OficinaModels.Cadastros;
using OficinaModels.Atendimentos;
using System;

namespace SQLiteEF.DataAccess
{
    public class DatabaseContext : DbContext
    {
        private readonly string DbPath;
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

        public static DatabaseContext GetContext(string v)
        {
            throw new NotImplementedException();
        }

        /*public DatabaseContext(string DbPath)
        {
            this.DbPath = DbPath;
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }*/
        public DatabaseContext(string DbPath)
        {
            this.DbPath = DbPath;
            //this.Database.EnsureDeleted();
            this.Database.Migrate();
        }
    }
}
