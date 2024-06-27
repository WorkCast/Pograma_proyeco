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
        public ArrayList Comments { get; set; }
        public int likes { get; set; }
        public string dirImagen { get; set; }
        public bool tieneImagen { get; set; }

        public Post(int id,string text)
        {
            this.id = id;
            this.text = text;
            Comments = new ArrayList();
            likes = 0;
        }

        public bool ExisteComentario(int id)
        {
            bool existe = false;
            foreach (Comentario com in Comments)
            {
                if (com.id == id)
                {
                    existe=true;
                }
            }
            return existe;
        }
        public Comentario BuscarComentId(int id)
        {
            Comentario come = null;
            foreach (Comentario com in Comments)
            { 
                if (com.id==id)
                {
                    come= com;
                }             
            }
            return come;
        }
        public void AddComent(Comentario coment)
        {
            Comments.Add(coment);
        }
        public void BorrarComent(int id)
        {
            Comentario come = BuscarComentId(id);

            foreach (Comentario com in Comments)
            {
                if (com == come)
                {
                    Comments.Remove(com);
                    break;
                }
            }
        }
        public void ModificarComent(int id, string text)
        {
            Comentario come = BuscarComentId(id);

            foreach (Comentario com in Comments)
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
            foreach (Comentario com in Comments)
            {
                coment += com.Mostrar();
            }
            return "{" + this.id + " - " + this.text + " - " + this.likes+ " "+ coment + "}";
        }

        public string MostrarSoloPost()
        {
            string coment = "";
            foreach (Comentario com in Comments)
            {
                coment += com.Mostrar();
            }
            return this.id + " - " + this.text + " - " + this.likes;
        }

    }
}
