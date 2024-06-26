using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Usuario
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string apell { get; set; }
        public string correo { get; set; }
        public string fechaN { get; set; }
        public string contra { get; set; }


        public Usuario(string id, string nom, string apell, string correo, string fechaN, string contra)
        {
            this.id = id;
            this.nom = nom;
            this.apell = apell;
            this.correo = correo;
            this.fechaN = fechaN;
            this.contra = contra;
        }
        public Usuario()
        {

        }
        public string MostrarU()
        {
            string textoUsr = this.id + " - " + this.nom + " - " + this.apell + " - " + this.correo + " - " + this.fechaN + " - " + this.contra;

            return textoUsr;
        }
    }
}
