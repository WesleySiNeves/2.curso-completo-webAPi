using Microsoft.EntityFrameworkCore;
using Models.Model;

namespace Infraestrutura.RepositoryPostGreSQLCore
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;"+
                    "Port=5432;Database=Clientes;"+
                    "User Id=postgres;"+
                    "Password=123");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
