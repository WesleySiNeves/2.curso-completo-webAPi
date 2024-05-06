using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.RepositoryPostGreSQLCore
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> Get()
        {
            return _context.Clientes.ToList();
        }
    }
}
