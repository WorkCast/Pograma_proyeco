using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Evento
    {
        public int idEvento { get; set; }
        public int idGrupo { get; set; }
        public string lugar { get; set; } 
        public string descripcion { get; set; }
        public string nombre { get; set; }
        public string fechaEvento { get; set; }
        public string dirImagen { get; set; }
        public Intereses intereses = new Intereses(null, null, null);

        public Evento(int idE,int idG, string lug, string desc, string fechaE, string nom, string dirImg)
        {
            this.idEvento = idE;
            this.idGrupo = idG;
            this.lugar = lug;
            this.descripcion = desc;
            this.fechaEvento = fechaE;
            this.nombre = nom;
            if (GruposData.ListaGrupos.ExisteGrupo(idG))
            {
            this.intereses = GruposData.ListaGrupos.ObtenerPorId(idG).intereses;
            }
            this.dirImagen = dirImg;
            
        }

        public Evento(int idE, string lug, string desc,string fechaE, string nom, string dirImg)
        {
            this.idEvento = idE;
            this.idGrupo = GrupoActual.grupo.id;
            this.lugar = lug;
            this.descripcion = desc;
            this.fechaEvento = fechaE;
            this.nombre = nom;
            this.dirImagen = dirImg;
            this.intereses = GrupoActual.grupo.intereses;
        }

        public Evento()
        {

        }

        public string MostrarEvento()
        {
            return  this.idEvento+" - "+this.idGrupo +" - " + this.nombre + " - " + this.descripcion + " - " + this.lugar+" - "+ this.fechaEvento + " - " + this.dirImagen+" - "+ this.intereses.MostrarIntereces();
        }
    }
}
