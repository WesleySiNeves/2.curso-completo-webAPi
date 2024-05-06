namespace Infraestrutura.RepositoryCoreSQLServer.Repositories
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }


        
    }
}
