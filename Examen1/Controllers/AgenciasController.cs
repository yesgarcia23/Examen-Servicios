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
    [RoutePrefix("api/Agencias")]
    public class AgenciasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Agencia> ConsultarTodos()
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Agencia ConsultarXId(int id)
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Agencia agen)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia =agen;
            return Agencia.Insertar();

        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Agencia agen)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = agen;
            return Agencia.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Agencia agen)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = agen;
            return Agencia.Eliminar();
        }
    }
}