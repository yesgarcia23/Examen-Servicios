using Examen1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen1.Clases
{
    public class clsAgencia
    {
        private ITM_VIVIENDASEntities itm = new ITM_VIVIENDASEntities();   
        public Agencia agencia { get; set; }
        public string Insertar()
        {
            try
            {
                itm.Agencias.Add(agencia);
                itm.SaveChanges();
                return "Agencia insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la Agencia" + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Agencia agen = Consultar(agencia.id);
                if (agen == null)
                {
                    return "Agencia no existe";
                }
                itm.Agencias.AddOrUpdate(agencia);
                itm.SaveChanges();
                return "Agencia actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la Agencia" + ex.Message;
            }
        }
        public Agencia Consultar(int id)
        {
            Agencia agen = itm.Agencias.FirstOrDefault(e => e.id == id);
            return agen;
        }
        public string Eliminar()
        {
            try
            {
                Agencia agen = Consultar(agencia.id);
                if (agen == null)
                {
                    return "Agencia no existe";
                }
                itm.Agencias.Remove(agen);
                itm.SaveChanges();
                return "Agencia eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la Agencia" + ex.Message;
            }
        }
        public List<Agencia> ConsultarTodos()
        {
            return itm.Agencias
                .ToList();
        }
    }
}