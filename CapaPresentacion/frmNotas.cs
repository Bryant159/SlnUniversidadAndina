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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        CapaNegocio.Notas nota1 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string curso = txtCurso.Text;
            int codAlumno = int.Parse(txtCodAlumno.Text);
            int cantNotas = int.Parse(txtCantNotas.Text);
            nota1.Curso = curso;
            nota1.CodAlumno = codAlumno;
            nota1.CantNotas = cantNotas;
            MessageBox.Show("Se han registrado correctamente los datos del nota1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string curso = nota1.Curso;
            int codAlumno = nota1.CodAlumno;
            int cantNotas = nota1.CantNotas;
            MessageBox.Show("Curso: " + curso + " Codigo del Alumno: " + codAlumno + " Cantidad de Notas: " + cantNotas);
        }

        private void btnAprobado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Aprobado());
        }

        private void btnDesaprobado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Desaprobado());

        }

        private void btnDispensado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Dispensado());

        }
    }
}
