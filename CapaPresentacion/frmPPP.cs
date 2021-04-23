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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        CapaNegocio.PPP ppp1 = new CapaNegocio.PPP();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string lugar = txtLugar.Text;
            string encargado = txtEncargado.Text;
            int celEncargado = int.Parse(txtCelEncargado.Text);
            ppp1.Lugar = lugar;
            ppp1.Encargado = encargado;
            ppp1.CelEncargado = celEncargado;
            MessageBox.Show("Se han registrado correctamente los datos del ppp1");
        }

        private void Escribir_Click(object sender, EventArgs e)
        {
            string lugar = ppp1.Lugar;
            string encargado = ppp1.Encargado;
            int celEncargado = ppp1.CelEncargado;
            MessageBox.Show("Lugar: " + lugar + " Encargado: " + encargado + " Celular del Encargado: " + celEncargado);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Aprender());
        }

        private void btnExperiencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Experiencia());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Trabajar());
        }
    }
}
