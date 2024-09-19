using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto
{
    public class Comentarios
    {
        public ArrayList Comments { get; set; } = new ArrayList();

        public bool ExisteComentario(int id)
        {
            bool existe = false;
            foreach (Comentario com in Comments)
            {
                if (com.id == id)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public Comentario BuscarComentId(int id)
        {
            Comentario come = null;
            foreach (Comentario com in Comments)
            {
                if (com.id == id)
                {
                    come = com;
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
                    com.texto = text;
                }
            }
        }
    }
}
