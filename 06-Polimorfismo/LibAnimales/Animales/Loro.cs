using LibAnimales.AnimalBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public class Loro : Animal
    {
        public Loro(string edad, string altura, string peso, string nombre,string pelaje) : base(edad, altura, peso)
        {
            Nombre = nombre;
            Pelaje = pelaje;
            
        }
        public string Nombre { get; set; }
        public string Pelaje { get; set; }

        public override string Imprimir()
        {
            return $"Nombre: {Nombre}, Pelaje: {Pelaje} {base.Imprimir()}";
        }
        public override string ImprimirComida(string comida)
        {
            return "Comida: " + comida;
        }
    }
}
