using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibTransporte
{
    public class Auto: transporteBase
    {
        
        public Auto(string maxFuel, int maxNroDePasajeros, int velocidad, string modelo) : base(maxFuel, maxNroDePasajeros, velocidad)
        {
            Modelo = modelo;
        }

        public string Modelo { get; set; }


        public override string ImprimirCaracteristicas()
        {
            return $"{base.ImprimirCaracteristicas()}, Modelo: {Modelo} ";
        }
        public override string Acelerar(int Velocidad)
        {
            return $"El auto esta acelerando a : {Velocidad} Km/h";
        }

        public override string Desacelerar(int Velocidad)
        {
            return $"El auto esta desacelerando a : {Velocidad} Km/h";
        }

        public string DoblarAIzq()
        {
            return "Doblar a la izquierda";
        }

        public string DoblarADcha()
        {
            return "Doblar a la derecha";
        }
    }
}

