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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del alumno
            frmAlumno formulario = new frmAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario docente
            frmDocente formulario = new frmDocente();
            formulario.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignatura formulario = new frmAsignatura();
            formulario.Show();
        }
        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio formulario = new frmLaboratorio();
            formulario.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJefePractica formulario = new frmJefePractica();
            formulario.Show();
        }
        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNotas formulario = new frmNotas();
            formulario.Show();
        }
        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPPP formulario = new frmPPP();
            formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRector formulario = new frmRector();
            formulario.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
