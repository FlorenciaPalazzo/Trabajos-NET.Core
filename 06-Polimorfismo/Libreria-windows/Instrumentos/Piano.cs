using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_windows.InstrumentoBase;

namespace Libreria_windows.Instrumentos
{
    public class Piano :InstrumentoMusical
    {
        public override string Afinar(string nombre)
        {
            return "Afinando" +" "+ nombre;
        }
    }
}
