using Examen1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen1.Clases
{
    public class clsVivienda
    {
        private ITM_VIVIENDASEntities itm = new ITM_VIVIENDASEntities();
        public Vivienda vivienda { get; set; }
        public string Insertar()
        {
            try
            {
                itm.Viviendas.Add(vivienda);
                itm.SaveChanges();
                return "Vivienda insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la Vivienda" + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Vivienda viv = Consultar(vivienda.id);
                if (viv == null)
                {
                    return "Vivienda no existe";
                }
                itm.Viviendas.AddOrUpdate(vivienda);
                itm.SaveChanges();
                return "Vivienda actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la Vivienda" + ex.Message;
            }
        }
        public Vivienda Consultar(int id)
        {
            Vivienda viv = itm.Viviendas.FirstOrDefault(e => e.id == id);
            return viv;
        }
        public string Eliminar()
        {
            try
            {
                Vivienda viv = Consultar(vivienda.id);
                if (viv == null)
                {
                    return "Vivienda no existe";
                }
                itm.Viviendas.Remove(viv);
                itm.SaveChanges();
                return "Vivienda eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Vivienda" + ex.Message;
            }
        }
        public List<Vivienda> ConsultarTodos()
        {
            return itm.Viviendas
                .ToList();
        }
    }
}