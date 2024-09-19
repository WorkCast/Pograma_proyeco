using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Proyecto
{
    public class Posts
    {
        //private static ArrayList posts = new ArrayList();
        public ArrayList posts { get; set; } = new ArrayList();
        public Random random = new Random();

        public void AddPost(Post post)
        {
            //post.id = posts.Count; // Asignar id basado en la posición en el ArrayList
            posts.Add(post);
        }

        public void DeletePost(int postId)
        {
            

            // Implementación para eliminar el post por Id
            foreach (Post post in posts)
            {
                if (post.id == postId)
                {
                    posts.Remove(post);
                    break;
                }
            }
        }

        public Post BuscarPostId(int postId)
        {
            // Implementación para obtener un post por Id
            foreach (Post post in posts)
            {
                if (post.id == postId)
                {
                    return post;
                }
            }
            return null;
        }

        public void CambiarTextPost(int postId, string newText)
        {
            // Implementación para actualizar el texto de un post por Id
            foreach (Post post in posts)
            {
                if (post.id == postId)
                {
                    post.text = newText;
                    break;
                }
            }
        }

        public void ActualizarLikes(int postId, int newLikes)
        {
            // Implementación para actualizar los likes de un post por Id
            foreach (Post post in posts)
            {
                if (post.id == postId)
                {
                    post.likes = newLikes;
                    break;
                }
            }
        }

        public ArrayList GetPosts()
        {
            return posts;
        }

        public void Mostrar()
        {
            foreach (Post post in posts)
            {
                Console.WriteLine(post.Mostrar());
            }
        }
        public bool ExistePost(int postId)
        {
            bool existe = false;
            foreach (Post post in posts)
            {
                if (post.id == postId)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public int NuevoIdPost()
        {
            int id=0;
            //genero un id aleatorio que aun no exista
            do
            {
                id = random.Next(1, int.MaxValue);
            } while (ExistePost(id));
            Console.WriteLine(id+ " nuevo id post");// nuevo id
            return id;
        }
        public bool ExisteComentario(int id)
        {
            bool existe = false;
            foreach (Post post in posts)
            {
                existe = existe || post.listaComentarios.ExisteComentario(id);
            }
            return existe;
        }

        public int NuevoIdComentario()
        {
            int id=0;
            //genero un id aleatorio que aun no exista
            do
            {
                id = random.Next(1, int.MaxValue);
            } while (ExisteComentario(id));
            Console.WriteLine(id + " nuevo id comentario");// nuevo id
            return id;
        }



    }
}

