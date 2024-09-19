using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto
{
    public class Post
    {
        public int id { get; set; }
        public string text { get; set; }
        //public ArrayList Comments { get; set; }
        
        public int likes { get; set; }
        public string dirImagen { get; set; }
        public bool tieneImagen { get; set; }
        public string idUsr { get; set; }
        public Comentarios listaComentarios = new Comentarios();
        public Post(int id,string text)
        {
            this.id = id;
            this.text = text;
            //Comments = new ArrayList();
            likes = 0;
        }

        public Post(int id, string text,string idU)
        {
            this.id = id;
            this.idUsr = idU;
            this.text = text;
            //Comments = new ArrayList();
            likes = 0;
        }

        
        public void ModificarComent(int id, string text)
        {
            Comentario come = listaComentarios.BuscarComentId(id);

            foreach (Comentario com in listaComentarios.Comments)
            {
                if (com == come)
                {
                    com.texto=text;
                }
            }
        }

        public string Mostrar()
        {
            string coment="";
            foreach (Comentario com in listaComentarios.Comments)
            {
                coment += com.Mostrar();
            }
            return "{" + this.id + " - " + this.text + " - " + this.likes+ " "+ coment + "}";
        }

        public string MostrarSoloPost()
        {
            string coment = "";
            foreach (Comentario com in listaComentarios.Comments)
            {
                coment += com.Mostrar();
            }
            return this.id + " - " + this.text + " - " + this.likes;
        }

    }
}
