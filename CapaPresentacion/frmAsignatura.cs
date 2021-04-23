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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            int horas = int.Parse(txtHoras.Text);
            int creditos = int.Parse(txtCreditos.Text);
            int trabajosPendientes = int.Parse(txtTrabajosPendientes.Text);
            asignatura1.Nombres = nombres;
            asignatura1.Horas = horas;
            asignatura1.Creditos = creditos;
            asignatura1.TrabajosPendientes = trabajosPendientes;
            MessageBox.Show("Se han registrado correctamente los datos de la asignatura1");
        }
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = asignatura1.Nombres;
            int horas = asignatura1.Horas;
            int creditos = asignatura1.Creditos;
            int trabajosPendientes = asignatura1.TrabajosPendientes;
            MessageBox.Show("Nombre: " + nombres + " Horas: " + horas + " Creditos: " + creditos + " Trabajos Pendientes: " + trabajosPendientes);
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Estudiar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprender());
        }

        private void btnPresentarTrabajos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.PresentarTrabajos());
        }
    }
}
