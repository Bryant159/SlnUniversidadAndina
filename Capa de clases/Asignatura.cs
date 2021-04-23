using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // atributos
        private string nombres;
        private int horas;
        private int creditos;
        private int trabajosPendientes;
        // propiedades
 
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Horas
        {
            get { return this.horas; }
            set { this.horas = value; }
        }
        public int Creditos
        {
            get { return this.creditos; }
            set { this.creditos = value; }
        }
        public int TrabajosPendientes
        {
            get { return this.trabajosPendientes; }
            set { this.trabajosPendientes = value; }
        }

        //metodos u operaciones
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo Aprender";
        }
        public string PresentarTrabajos()
        {
            return "No se ha implementado el metodo presentar trabajos";
        }
    }
}
