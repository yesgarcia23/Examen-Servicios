using Examen1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen1.Clases
{
    public class clsVenta
    {
        private ITM_VIVIENDASEntities itm = new ITM_VIVIENDASEntities();
        public Venta venta { get; set; }
        public string Insertar()
        {
            try
            {
                itm.Ventas.Add(venta);
                itm.SaveChanges();
                return "Venta insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la Venta" + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Venta ven = Consultar(venta.id);
                if (ven == null)
                {
                    return "Venta no existe";
                }
                itm.Ventas.AddOrUpdate(venta);
                itm.SaveChanges();
                return "Venta actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la Venta" + ex.Message;
            }
        }
        public Venta Consultar(int id)
        {
            Venta ven = itm.Ventas.FirstOrDefault(e => e.id == id);
            return ven;
        }
        public string Eliminar()
        {
            try
            {
                Venta ven = Consultar(venta.id);
                if (ven == null)
                {
                    return "Venta no existe";
                }
                itm.Ventas.Remove(ven);
                itm.SaveChanges();
                return "Venta eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Venta" + ex.Message;
            }
        }
        public List<Venta> ConsultarTodos()
        {
            return itm.Ventas
                .ToList();
        }
    }
}