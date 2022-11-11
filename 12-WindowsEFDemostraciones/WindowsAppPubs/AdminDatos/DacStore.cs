using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
            static PubContext context = new PubContext();


        public static List<Store> Lista() 
        {
            List<Store> listaStore = context.Stores.ToList();
            return listaStore;
        }

        public static Store TraerUno(string id)
        {
            Store storeId = context.Stores.Find(id);
            return storeId;
        }

        public static int Nuevo(Store storeNuevo)
        {
            context.Stores.Add(storeNuevo);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
            
        }

        public static int Modificar(Store storeModificar)
        {

            //Store findId = context.Stores.Find(storeModificar.stor_id);

            //if (findId != null)
            //{

            //    findId.stor_name = storeModificar.stor_name;
            //    findId.stor_address = storeModificar.stor_address;
            //    findId.city = storeModificar.city;
            //    findId.state = storeModificar.state;
            //    findId.zip = storeModificar.zip;

            //    findId = storeModificar;
            //}

            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Eliminar(Store storeEliminar)
        {
            Store findId = context.Stores.Find(storeEliminar);

            if (findId != null)
            {
                context.Stores.Remove(findId);
            }
            int filasAfectadas= context.SaveChanges();
            return filasAfectadas;
        }
    }
}



