using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsCompaniaAerea.Models.Derivada;

namespace WindowsCompaniaAerea
{
    public partial class Form1 : Form
    {
        public List<Azafata> listaAzafatas = new List<Azafata>();
        public Jet jet1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJet_Click(object sender, EventArgs e)
        {
            List<Jet> listaJets = new List<Jet>();
            
            Piloto pilotoJet1 = new Piloto("Morales", "Juan Carlos");
            Copiloto copilotoJet1 = new Copiloto("Martinez", "Oscar");
            Azafata azafataJet1 = new Azafata("Gonzalez", "Mariela");

            if (azafataJet1.ABordo != true)
            {                                                                   
                jet1 = new Jet(4,200,Convert.ToDecimal(250.2),3, pilotoJet1,copilotoJet1,azafataJet1);
                listaJets.Add(jet1);     
                MessageBox.Show($"Jet creado con exito");
                MessageBox.Show (jet1.Despegar(" 5"));
                MessageBox.Show(jet1.Aterrizar(" 1"));
            }

            MessageBox.Show($"Piloto:{pilotoJet1.Nombre}, {pilotoJet1.Apellido}\nCopiloto: {copilotoJet1.Nombre},{copilotoJet1.Apellido}\n" +
                $"Azafata:{azafataJet1.Nombre}, {azafataJet1.Apellido}\nCapacidad:{jet1.Capacidad} Velocidad:{jet1.Velocidad} Costo de hora:{jet1.CostoDeHora} Cantidad de pasajeros:{jet1.CantidadPasajeros}");
           
            //en el grid no me deja mostrar los nombres de piloto, copiloto y azafata porque son obj
            gridListaJets.DataSource = listaJets;

        }

        private void btnHelicoptero_Click(object sender, EventArgs e)
        {
            List<Helicoptero> listaHelicoptero = new List<Helicoptero>();

            Helicoptero helicoptero1 = new Helicoptero(4, 250, Convert.ToDecimal(235.2), 3,3);

            listaHelicoptero.Add(helicoptero1);
            MessageBox.Show($"Helicoptero creado con exito");
            
            gridListaJets.DataSource = listaHelicoptero;

        }

        private void btnAgregarAzafata_Click(object sender, EventArgs e)
        {         
            listaAzafatas.Add(new Azafata("Gonzalez", "Maria"));
            listaAzafatas.Add(new Azafata("Perez", "Julia"));

            MessageBox.Show($"Azafatas agregadas");
        }

        private void btnQuitarAzafata_Click(object sender, EventArgs e)
        {
            listaAzafatas.Remove(listaAzafatas[0]);
            MessageBox.Show($"Azafatas eliminada");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {            
            gridAzafatas.DataSource = listaAzafatas;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            gridAzafatas.DataSource = null;
            gridAzafatas.Rows.Clear();
        }

        
    }
}
