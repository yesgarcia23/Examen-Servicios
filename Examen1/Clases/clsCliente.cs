using Examen1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen1.Clases
{
    public class clsCliente
    {
        private ITM_VIVIENDASEntities itm = new ITM_VIVIENDASEntities();
        public Cliente cliente { get; set; }
        public string Insertar()
        {
            try
            {
                itm.Clientes.Add(cliente);
                itm.SaveChanges();
                return "Cliente insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Cliente" + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Cliente cli = Consultar(cliente.id);
                if (cli == null)
                {
                    return "Cliente no existe";
                }
                itm.Clientes.AddOrUpdate(cliente);
                itm.SaveChanges();
                return "Cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Cliente" + ex.Message;
            }
        }
        public Cliente Consultar(int id)
        {
            Cliente cli = itm.Clientes.FirstOrDefault(e => e.id == id);
            return cli;
        }
        public string Eliminar()
        {
            try
            {
                Cliente cli = Consultar(cliente.id);
                if (cli == null)
                {
                    return "Cliente no existe";
                }
                itm.Clientes.Remove(cli);
                itm.SaveChanges();
                return "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Cliente" + ex.Message;
            }
        }
        public List<Cliente> ConsultarTodos()
        {
            return itm.Clientes
                .ToList();
        }
    }
}