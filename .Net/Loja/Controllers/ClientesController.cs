using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Loja.Models;
using Loja.Banco;
using System.Linq;

namespace Loja.Controllers
{
    [Route("Api")]
    public class ClientesController : Controller
    {        
        private readonly BancoDados Banco;
        public ClientesController(BancoDados _Banco)/*teste versionamento*/
        {
            Banco = _Banco;
        }
        [Route("Clientes2")]
        [HttpGet]
        public List<Cliente> Clientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente = new Cliente();            
            cliente.ClienteId = 1;
            cliente.Nome = "Ana";
            cliente.DataNascimento = "09/12/1984";
            clientes.Add(cliente);

            Cliente cliente2 = new Cliente();
            cliente2.ClienteId = 2;
            cliente2.Nome = "Michel";
            cliente2.DataNascimento = "14/08/2020";
            clientes.Add(cliente2);

            Cliente cliente3 = new Cliente();
            cliente3.ClienteId = 3;
            cliente3.Nome = "Tarso";
            cliente3.DataNascimento = "03/12/1976";
            clientes.Add(cliente3);
            
            clientes.Add(new Cliente() {ClienteId = 4,Nome = "Maria",DataNascimento= "10/10/1990"});
            
            // clientes.add(new cliente() {Nome : "Tarso", DataNascimento :"02/12/1976"});           
            // clientes.add(new cliente() {Nome : "Michel", DataNascimento :"14/08/1984"})             
            return clientes;
        }        
        [Route("Clientes")]
        [HttpGet]
        public IActionResult GET()
        {
            //return Ok(Banco.Clientes);    
            return Ok(Banco.Clientes.ToList()) ;       
        }
        [Route("Clientes")]
        [HttpPost]
        public IActionResult POST ([FromBody] Cliente cliente)
        {   
           Cliente cli = new Cliente(); 
           cli.ClienteId = cliente.ClienteId;
           cli.Nome      = cliente.Nome;         
           cli.DataNascimento = cliente.DataNascimento;
           Banco.Add(cli);       
           Banco.SaveChanges();   
           return Ok(cli);
        }
        [Route("Clientes")]
        [HttpPut]       
        public IActionResult PUT([FromBody] Cliente cliente )
        {            
            Cliente cli = new Cliente(){ClienteId = cliente.ClienteId,Nome = cliente.Nome,    DataNascimento = cliente.DataNascimento};
            Banco.Update(cli);
            Banco.SaveChanges();
            return Ok(cli);
        }
        [Route("Clientes")]
        [HttpDelete]
        public IActionResult DELETE(int Id)
        {                 
            var cliente = Banco.Clientes.Where(c => c.ClienteId == Id).FirstOrDefault();
            Banco.Remove(cliente);
            Banco.SaveChanges();
            return Ok();
        }
    }
}