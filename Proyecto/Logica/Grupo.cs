using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto;

namespace Proyecto
{
    public class Grupo
    {
        // Propiedades de la clase Grupo que corresponden a las columnas de la tabla.
        public int id { get; set; }
        public int idCreador { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string dirImagen;
        public Usuarios usuarios = new Usuarios();
        

        public Intereses intereses = new Intereses(null, null, null);
        public Posts postsGrupo = new Posts();
        public Eventos eventosGrupo = new Eventos();

        
        public Grupo(int idGrupo, int idCrea, string nombre, string descripcionGrupo)
        {
            this.id = idGrupo;
            this.idCreador = idCrea;
            this.nombre = nombre;
            descripcion = descripcionGrupo;
            
        }
        
        public Grupo()
        {
        }

        public string MostrarGrupo()
        {
            
            // Retorna el grupo en el formato id - nombre - descripción - etiquetas
            return this.id +" - "+ this.idCreador + " - " + this.nombre + " - " + this.descripcion + " - " + this.intereses.MostrarIntereces();
        }

       


    }
}
