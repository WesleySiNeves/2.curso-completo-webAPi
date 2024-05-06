
using Infraestrutura.RepositoryPostGreSQLCore;
using Microsoft.AspNetCore.Mvc;
using Models.Model;

namespace WebApiCoreAplication.Controllers
{
    [ApiController]
    [Route("api/v1/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesRepository _repository;

        public ClienteController(IClientesRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Add(Cliente cliente)
        {

            var cli = new Cliente(cliente.IdCliente, cliente.Nome);

            _repository.Add(cli);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _repository.Get();

            return Ok(clientes);
        
        }
    }
}
