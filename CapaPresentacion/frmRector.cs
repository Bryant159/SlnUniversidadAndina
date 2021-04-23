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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int añoRectorado = int.Parse(txtAñoRectorado.Text);
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.AñoRectorado = añoRectorado;
            MessageBox.Show("Se han registrado correctamente los datos del rector1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int edad = rector1.Edad;
            int añoRectorado = rector1.AñoRectorado;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " Año de Rectorado: " + añoRectorado);
        }

        private void btnApoyar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Apoyar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Trabajar());
        }

        private void btnDarIndicaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.DarIndicaciones());
        }

        private void btnHacerActividades_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.HacerActvidades());
        }
    }
}
