using CadastroClientsAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClientsAPI.Controllers
{//mapa da rota de dados => onde processa, aqui é quem processa os dados... 
    // o localhost que retorna é: https://localhost:xxxx/openapi/v1.json ->
    // vimos que temos que ter atençao a nomeclatura da rota, que se baseia no nome do controller
    [ApiController]
    [Route("api/[controller]")]
    //o controller é a classe a ser usada para rotiar o resultado apresentado ou direcionado dentro do codigo
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterClients()
        {//esse metodo esta executando o return direto na rota clients da API
            
            Console.WriteLine("Controller executou!");

            return Ok(new[]
            {
                "João",
                "Maria",
                "José"
            });
        }

        [HttpGet("{id}")]
        public IActionResult ListClient(int id)
        {
            var repository = new ClientsRepository();//quem chama
            var clients = repository.ListClients();//quam lê

            return Ok(clients);//quem mostra
        }
    }
}
