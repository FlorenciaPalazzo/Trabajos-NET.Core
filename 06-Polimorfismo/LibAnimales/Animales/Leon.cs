using LibAnimales.AnimalBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public class Leon: Animal
    {
        public Leon(string edad, string altura, string peso, string nombre, string sonido): base(edad, altura, peso)
        {
            Nombre = nombre;
            Sonido = sonido;

        }

        public string Nombre { get; set; }
        public string Sonido { get; set; }

        public override string Imprimir()
        {
            return  $"Nombre: {Nombre}, Sonido: {Sonido} { base.Imprimir()}"   ;
        }

        public override string ImprimirComida(string comida)
        {
            return "Comida:" + " " + comida;
        }
    }
}
