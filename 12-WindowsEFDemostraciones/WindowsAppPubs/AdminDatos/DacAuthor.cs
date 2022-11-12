using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        static PubContext context = new PubContext();
        public static List<Author> Lista()
        {
            List<Author> listaAutores = context.Authors.ToList();
            return listaAutores;
        }

        public static Author TraerUno(string id)
        {
            Author author = context.Authors.Find(id);
            return author;
        }

        public static int Nuevo(Author authorNuevo)
        {
            context.Authors.Add(authorNuevo);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Modificar(Author authorModificado)
        {
            

            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Eliminar(Author author)
        {
            Author findId = context.Authors.Find(author.au_id);

            if (findId != null)
            {
                context.Authors.Remove(findId);
            }
            int filasAfectadas= context.SaveChanges();
            return filasAfectadas;
        }
    }
}
