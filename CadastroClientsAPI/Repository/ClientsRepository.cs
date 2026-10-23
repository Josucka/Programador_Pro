using CadastroClientsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClientsAPI.Repository
{//mapa da rota de dados => onde passa, aqui é quem recebe os dados...
    internal class ClientsRepository
    {
        public List<Clients> ListClients()
        {
            Clients clients = new Clients();//nova instancia que chama
            List<Clients> lista = new List<Clients>();// instancia para criar
            clients.Id = 1;
            clients.Name = "Josue";
            clients.Fone = "62985054112";
            clients.Email = "jbprogrammer.8@gmail.com";

            lista.Add(clients);//metodo que cria nova lista 
            return lista;//o que responde
        }
    }
}