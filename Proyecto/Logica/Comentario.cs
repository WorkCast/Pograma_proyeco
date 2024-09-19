using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Comentario
    {
        public int id { get; set; }
        public string texto { get; set; }
        public Comentario(int id, string text)
        {
            this.id = id;
            this.texto = text;
        }

        public string Mostrar()
        {
            return "(" + this.id + " - " + this.texto + ")";
        }

        public string Mostrar2()
        {
            return this.id + " - " + this.texto;
        }
    }
}
