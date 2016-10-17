using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
    public class ClienteBLL
    {
        public static bool Guardar(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                RegistrosClientesDb db = new RegistrosClientesDb();

                db.cliente.Add(cliente);

                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        public static void Eliminar(int id)
        {
            var db = new RegistrosClientesDb();

            Cliente cliente  = Buscar(id);

            db.cliente.Remove(cliente);
            db.SaveChanges();
        }

        public static Cliente Buscar(int id)
        {
            var db = new RegistrosClientesDb();

            return db.cliente.Find(id);
        }

        public static List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();

            var db = new RegistrosClientesDb();

            lista = db.cliente.ToList();

            return lista;
        }

        public static List<Cliente> GetLista(int clienteId)
        {
            List<Cliente> lista = new List<Cliente>();

            var db = new RegistrosClientesDb();

            lista = db.cliente.Where(p => p.ClienteId == clienteId).ToList();

            return lista;
        }
    }
}
