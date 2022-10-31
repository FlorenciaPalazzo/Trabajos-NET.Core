using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director: Profesor
    {
        //Constructor por defecto
        public Director() { }
        //Constructor por parametro
        public Director(string nombre, string apellido, string titulo):base(nombre, apellido, titulo)
        {

        }
        
    }
}
