using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string ubicacion = txtUbicacion.Text;
            int aforo = int.Parse(txtAforo.Text);
            int cantHerramientas = int.Parse(txtCantHerramientas.Text);
            laboratorio1.Ubicacion = ubicacion;
            laboratorio1.Aforo = aforo;
            laboratorio1.CantHerramientas = cantHerramientas;
            MessageBox.Show("Se han registrado correctamente los datos de laboratorio1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string ubicacion = laboratorio1.Ubicacion;
            int aforo = laboratorio1.Aforo;
            int cantHerramientas = laboratorio1.CantHerramientas;
            MessageBox.Show("Ubicacion: " + ubicacion + " Aforo: " + aforo + " Cantidad de Herramientas: " + cantHerramientas);
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Investigar());
        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Observar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Aprender());
        }
    }
}
