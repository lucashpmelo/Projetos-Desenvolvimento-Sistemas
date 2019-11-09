using Microsoft.EntityFrameworkCore;
using IDPropertiesEF.Models;

using OficinaModels.Cadastros;

namespace SQLiteEF.DataAccess
{
    public class DatabaseContext : DbContext
    {
        private readonly string DbPath;
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
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
