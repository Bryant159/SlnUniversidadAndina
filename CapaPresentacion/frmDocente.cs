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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        // Instanciar la clase a traves de un objeto
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarLaboral = txtLugarLaboral.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Edad = edad;
            docente1.LugarLaboral = lugarLaboral;
            MessageBox.Show("Se han registrado correctamente los datos del docente1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            int edad = docente1.Edad;
            string lugarLaboral = docente1.LugarLaboral;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " Lugar Laboral: " + lugarLaboral);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Estudiar
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Trabajar());
        }

        private void btnAprobarAlumno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.AprobarAlumno());
        }

        private void btnDesaprobarAlumno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.DesaprobarAlumno());
        }
    }
}
