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
    [RoutePrefix("api/Viviendas")]
    public class ViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vivienda> ConsultarTodos()
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Vivienda ConsultarXId(int id)
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vivienda viv)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = viv;
            return Vivienda.Insertar();

        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vivienda viv)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = viv;
            return Vivienda.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Vivienda viv)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = viv;
            return Vivienda.Eliminar();
        }
    }
}