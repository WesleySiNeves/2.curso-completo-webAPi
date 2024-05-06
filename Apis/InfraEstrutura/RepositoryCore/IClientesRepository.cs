using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.RepositoryPostGreSQLCore
{
    public interface IClientesRepository
    {

        void Add(Cliente cliente);

        List<Cliente> Get();


    }
}
