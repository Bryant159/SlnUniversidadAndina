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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        // Instanciar la clase a traves de un objeto
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();
        private void button1_Click(object sender, EventArgs e) 
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos del alumno1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " Lugar Nacmiento: " + lugarNacimiento);
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Estudiar
            MessageBox.Show(alumno1.Estudiar());
        }
        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Trabajar());
        }
        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.AprobarExamen());
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
