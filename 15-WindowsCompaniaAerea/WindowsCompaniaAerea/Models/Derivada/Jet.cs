using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsCompaniaAerea.Models.Base;

namespace WindowsCompaniaAerea.Models.Derivada
{
    public class Jet: Transporte
    {

        public Jet(int capacidad, int velocidad, decimal costoDeHora, int cantidadPasajeros, Piloto piloto, Copiloto copiloto, Azafata azafata) : base(capacidad, velocidad, costoDeHora, cantidadPasajeros)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafata = azafata;
        }
        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
        public Azafata Azafata { get; set; }
        

        public override string Despegar(string pista)
        {
            return base.Despegar() + " en pista "+pista;
        }

        public override string Aterrizar(string pista)
        {
            return base.Aterrizar() + " en pista " + pista;
        }

        public string AgregarAzafata(string nombre, string apellido)
        {
           Azafata nuevaAzafata = new Azafata(nombre, apellido) ;

           return "Azafata" + nuevaAzafata.Nombre + " " + nuevaAzafata.Apellido;
        }
        public Azafata QuitarAzafata()
        {
            Azafata = null;
            return Azafata;
        }

        public string Mantenimiento()
        {
            QuitarAzafata();
            return "Jet en mantenimiento...";
        }

        public string Informe(Piloto piloto, Copiloto copiloto, Azafata azafata)
        {
            return "Piloto:" + piloto.Nombre + " " + piloto.Apellido + "\nCopiloto:" + copiloto.Nombre + " " + copiloto.Apellido +
                "\n Azafata" + azafata.Nombre + " " + azafata.Apellido;
            ;
        }


    }
}
