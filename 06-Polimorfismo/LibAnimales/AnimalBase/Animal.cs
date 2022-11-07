using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.AnimalBase
{
     public abstract class Animal
    {
        private string EdadAnimal;
        private string AlturaAnimal;
        private string PesoAnimal;
        public Animal(string edad, string altura, string peso)
        {
            EdadAnimal = edad;
            AlturaAnimal = altura;        
            PesoAnimal = peso;      
        }

        public string Edad { get { return EdadAnimal; } }
        public string Altura { get { return AlturaAnimal; }  }
        public string Peso { get { return PesoAnimal; }  }
       
        public virtual string Imprimir()
        {
            return $"Edad: {Edad}, Altura: {Altura}, Peso:{Peso},";
        }
        public abstract string ImprimirComida(string comida);
            
    }
}
