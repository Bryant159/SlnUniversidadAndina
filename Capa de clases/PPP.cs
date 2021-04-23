using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        // atributos
        private string lugar;
        private string encargado;
        private int celEncargado;
        // propiedades
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }
        public int CelEncargado
        {
            get { return this.celEncargado; }
            set { this.celEncargado = value; }
        }



        //metodos u operaciones
        public string Aprender()
        {
            return "No se ha implementado el metodo Aprender";
        }
        public string Experiencia()
        {
            return "No se ha implementado el metodo Experiencia";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo aprobar Trabajar";
        }
    }
}
