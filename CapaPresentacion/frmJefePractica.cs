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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefe1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int dni = int.Parse(txtDni.Text);
            jefe1.Apellidos = apellidos;
            jefe1.Nombres = nombres;
            jefe1.Edad = edad;
            jefe1.DNI = dni;
            MessageBox.Show("Se han registrado correctamente los datos del jefe1");
        }
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefe1.Apellidos;
            string nombres = jefe1.Nombres;
            int edad = jefe1.Edad;
            int dni = jefe1.DNI;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " DNI: " + dni);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Ayudar());
        }
        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Enseñar());
        }
        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
