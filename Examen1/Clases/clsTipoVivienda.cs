using Examen1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen1.Clases
{
    public class clsTipoVivienda
    {
        private ITM_VIVIENDASEntities itm = new ITM_VIVIENDASEntities();
        public TipoVivienda tipoVivienda { get; set; }
        public string Insertar()
        {
            try
            {
                itm.TipoViviendas.Add(tipoVivienda);
                itm.SaveChanges();
                return "Tipo de Vivienda insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Tipo de Vivienda" + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                TipoVivienda tipo = Consultar(tipoVivienda.id);
                if (tipo == null)
                {
                    return "Tipo de Vivienda no existe";
                }
                itm.TipoViviendas.AddOrUpdate(tipoVivienda);
                itm.SaveChanges();
                return "Tipo de Vivienda actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el TipoVivienda" + ex.Message;
            }
        }
        public TipoVivienda Consultar(int id)
        {
            TipoVivienda tipo = itm.TipoViviendas.FirstOrDefault(e => e.id == id);
            return tipo;
        }
        public string Eliminar()
        {
            try
            {
                TipoVivienda tipo = Consultar(tipoVivienda.id);
                if (tipo == null)
                {
                    return "TipoVivienda no existe";
                }
                itm.TipoViviendas.Remove(tipo);
                itm.SaveChanges();
                return "Tipo de Vivienda eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Tipo de Vivienda" + ex.Message;
            }
        }
        public List<TipoVivienda> ConsultarTodos()
        {
            return itm.TipoViviendas
                .ToList();
        }
    }
}