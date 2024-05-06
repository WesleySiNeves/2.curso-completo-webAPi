using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Model
{
    [Table("Clientes'")]
    public class Cliente
    {

        public Cliente(int id , string nome)
        {
            IdCliente = id;
            Nome = nome;
                
        }
        [Key]
        public int IdCliente { get; private set; }


        public string Nome { get;  private set; }
    }
}
