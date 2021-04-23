using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // atributos
        private string ubicacion;
        private int aforo;
        private int cantHerramientas;
        // propiedades
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int Aforo
        {
            get { return this.aforo; }
            set { this.aforo = value; }
        }
        public int CantHerramientas
        {
            get { return this.cantHerramientas; }
            set { this.cantHerramientas = value; }
        }


        //metodos u operaciones
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string Observar()
        {
            return "No se ha implementado el metodo observar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }
     
    }

}
