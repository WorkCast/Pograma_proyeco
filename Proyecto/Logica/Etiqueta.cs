using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Etiqueta
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public Etiqueta(string id, string nom)
        {
            this.id = id;
            this.nombre = nom;
        }

        public Etiqueta()
        {

        }
    }
}
