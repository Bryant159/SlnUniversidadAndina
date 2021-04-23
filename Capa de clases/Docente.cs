using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarLaboral;
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
        public string LugarLaboral
        {
            get { return this.lugarLaboral; }
            set { this.lugarLaboral = value; }
        }

       

        //metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarAlumno()
        {
            return "No se ha implementado el metodo aprobar Alumno";
        }
        public string DesaprobarAlumno()
        {
            return "No se ha implementado el metodo desaprobar Alumno";
        }
    }
}


