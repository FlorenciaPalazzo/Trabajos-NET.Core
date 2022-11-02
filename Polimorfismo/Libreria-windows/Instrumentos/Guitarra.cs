using Libreria_windows.InstrumentoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_windows.Instrumentos
{
    public class Guitarra : InstrumentoMusical
    {
        public override string Afinar(string nombre)
        {
            return "Afinando" +" "+ nombre;
        }
    }
}
