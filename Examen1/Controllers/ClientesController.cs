using Examen1.Clases;
using Examen1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Examen1.Controllers
{
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cliente> ConsultarTodos()
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Cliente ConsultarXId(int id)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cliente cli)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cli;
            return Cliente.Insertar();

        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente cli)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cli;
            return Cliente.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Cliente cli)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cli;
            return Cliente.Eliminar();
        }
    }
}