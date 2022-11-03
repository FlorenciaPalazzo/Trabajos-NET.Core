using Entidades.Personas;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

                   
            gridMedicos.DataSource = AdmMedico.Listar();

            foreach (var item in AdmMedico.Listar("Clinico"))
            {
                lstMedicosClinicos.Items.Add($"{item.Nombre} {item.Apellido}");
            }

          
            gridPacientes.DataSource = AdmPaciente.Insertar();



            foreach (var item in AdmHabitacion.Listar()) 
	        {
                lstHabitaciones.Items.Add($"{item.Numero} {item.Estado}");
	        }
        }
    }
}
