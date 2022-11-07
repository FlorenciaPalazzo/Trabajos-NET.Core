using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte
{
    public class Avion : transporteBase
    {

        public Avion(string maxFuel, int maxNroDePasajeros, int velocidad, int maxAltitud, int nroDeMotores) :base(maxFuel, maxNroDePasajeros, velocidad)
        {
          
            MaxAltitud = maxAltitud;
            NroDeMotores = nroDeMotores;

        }

        public int MaxAltitud { get; set; }
        public int NroDeMotores { get; set; }
    

        public override string ImprimirCaracteristicas()
        {
            return $"{base.ImprimirCaracteristicas()}, Maxima Altitud:{MaxAltitud}, Numero Motores: {NroDeMotores} ";

        }

        public override string Acelerar(int velocidad)
        {
            return $"El avión acelera a: {velocidad} Km/h ";
        }

        public override string Desacelerar(int velocidad)
        {
            return $"El avión desacelera a: {velocidad} Km/h ";
        }

        public string Ascender()
        {
            return "Está ascendiendo";
        }

        public string Descender()
        {
            return "Esta descendiendo";
        }
    }
}
