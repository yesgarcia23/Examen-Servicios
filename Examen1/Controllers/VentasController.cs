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
    [RoutePrefix("api/Ventas")]
    public class VentasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Venta> ConsultarTodos()
        {
            clsVenta Venta = new clsVenta();
            return Venta.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Venta ConsultarXId(int id)
        {
            clsVenta Venta = new clsVenta();
            return Venta.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Venta ven)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = ven;
            return Venta.Insertar();

        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Venta ven)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = ven;
            return Venta.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Venta ven)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = ven;
            return Venta.Eliminar();
        }
    }
}