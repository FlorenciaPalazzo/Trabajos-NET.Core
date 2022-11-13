using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsCompaniaAerea.Models.Base;

namespace WindowsCompaniaAerea.Models.Derivada
{
    public class Helicoptero: Transporte
    {
        public Helicoptero(int capacidad, int velocidad, decimal costoDeHora, int cantidadPasajeros, int cantidadAspas) : base(capacidad, velocidad, costoDeHora, cantidadPasajeros)
        {
            CantidadAspas = cantidadAspas;
        }

        public int CantidadAspas { get; set; }


        public override string Despegar()
        {
            string mensaje = "";
            if (Velocidad > 160)
            {
                mensaje = ", llegó a la velocidad crucero";
            }
            return base.Despegar() + mensaje;
        }

        public override string Aterrizar()
        {
            return base.Aterrizar() + " Helicoptero";
        }


    }
}
