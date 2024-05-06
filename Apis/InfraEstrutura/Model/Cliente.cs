using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.RepositoryCoreSQLServer.Model
{
    [Table("Clientes")]
    public class Cliente
    {
        public Cliente(int idCliente , string nome)
        {
            IdCliente = idCliente;
            Nome = nome;
        }
        [Key]
        public int IdCliente { get; private set; }


        public string Nome { get; private set; }
    }
}
