using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCompaniaAerea.Models.Base
{
    public abstract class Transporte
    {

        public int Capacidad { get; set; }
        public int Velocidad { get; set; }
        public decimal CostoDeHora { get; set; }
        public int CantidadPasajeros { get; set; }

        public virtual string Despegar()
        {
            return "Despegando";
        }

        public virtual string Aterrizar()
        {
            return "Aterrizando";
        }

        public virtual string Despegar(string pista)
        {
            return "Despegando, pista " + pista;
        }

        public virtual string Aterrizar(string pista)
        {
            return "Aterrizando, pista " + pista;
        }

        public Transporte(int capacidad, int velocidad, decimal costoDeHora, int cantidadPasajeros)
        {
            Capacidad = capacidad;
            Velocidad = velocidad;
            CostoDeHora = costoDeHora;
            CantidadPasajeros = cantidadPasajeros;
        }

        public string Informar()
        {
            return "Capacidad: " + Capacidad + ", velocidad: " + Velocidad + ", costo de hora: " + CostoDeHora;
        }
    }
}
