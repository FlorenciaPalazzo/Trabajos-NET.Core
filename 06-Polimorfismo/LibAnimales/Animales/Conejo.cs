using LibAnimales.AnimalBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public class Conejo:Animal
    {
        public Conejo(string edad, string altura, string peso, string agilidad, string nombre) : base(edad, altura, peso)
        {
            Agilidad = agilidad;
            Nombre = nombre;

        }
        public string Agilidad { get; set; }
        public string Nombre { get; set; }

        public override string Imprimir()
        {
            return $"Nombre: {Nombre}, Agilidad: {Agilidad} {base.Imprimir()}";
        }
        public override string ImprimirComida(string comida)
        {
            return "Comida: " + comida;
        }
    }
}
