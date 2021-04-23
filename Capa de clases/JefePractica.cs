using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        // atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private int dni;
        // propiedades
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        //metodos u operaciones
        public string Ayudar()
        {
            return "No se ha implementado el metodo ayudar";
        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
    }
}
