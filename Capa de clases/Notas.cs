using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        // atributos
        private string curso;
        private int codAlumno;
        private int cantNotas;
        // propiedades
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public int CodAlumno
        {
            get { return this.codAlumno; }
            set { this.codAlumno = value; }
        }
        public int CantNotas
        {
            get { return this.cantNotas; }
            set { this.cantNotas = value; }
        }




        //metodos u operaciones
        public string Aprobado()
        {
            return "No se ha implementado el metodo aprobado";
        }
        public string Desaprobado()
        {
            return "No se ha implementado el metodo desaprobado";
        }
        public string Dispensado()
        {
            return "No se ha implementado el metodo aprobar dispensado";
        }
    }
}
