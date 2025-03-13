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
    [RoutePrefix("api/TipoViviendas")]
    public class TipoViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TipoVivienda> ConsultarTodos()
        {
            clsTipoVivienda TipoVivienda = new clsTipoVivienda();
            return TipoVivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public TipoVivienda ConsultarXId(int id)
        {
            clsTipoVivienda TipoVivienda = new clsTipoVivienda();
            return TipoVivienda.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TipoVivienda tipo)
        {
            clsTipoVivienda TipoVivienda = new clsTipoVivienda();
            TipoVivienda.tipoVivienda = tipo;
            return TipoVivienda.Insertar();

        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TipoVivienda tipo)
        {
            clsTipoVivienda TipoVivienda = new clsTipoVivienda();
            TipoVivienda.tipoVivienda = tipo;
            return TipoVivienda.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] TipoVivienda tipo)
        {
            clsTipoVivienda TipoVivienda = new clsTipoVivienda();
            TipoVivienda.tipoVivienda = tipo;
            return TipoVivienda.Eliminar();
        }
    }
}