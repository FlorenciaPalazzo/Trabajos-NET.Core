using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte
{
    public abstract class transporteBase
    {
        public transporteBase(string maxFuel, int maxNroDePasajeros, int velocidad)
        {
            MaxFuel = maxFuel;
            MaxNroDePasajeros = maxNroDePasajeros;
            Velocidad = velocidad;
        }

        public string MaxFuel { get; set; }
        public int MaxNroDePasajeros { get; set; }
        public int Velocidad { get; set; }

        public virtual string ImprimirCaracteristicas()
        {
            return $"MaxFuel:{MaxFuel}, Maximo num de pasajeros:{MaxNroDePasajeros}";
        }
        public abstract string Acelerar(int Velocidad);
        public abstract string Desacelerar(int Velocidad);

    }
}
