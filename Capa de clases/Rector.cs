using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class  Rector
    {
        // atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private int añoRectorado;
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
        public int AñoRectorado
        {
            get { return this.añoRectorado; }
            set { this.añoRectorado = value; }
        }



        //metodos u operaciones
        public string Apoyar()
        {
            return "No se ha implementado el metodo apoyar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string DarIndicaciones()
        {
            return "No se ha implementado el metodo dar indicaciones";
        }
        public string HacerActvidades()
        {
            return "No se ha implementado el metodo hacer actividades";
        }
    }
}
