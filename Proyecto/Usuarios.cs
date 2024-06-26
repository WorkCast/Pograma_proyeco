using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Usuarios
    {
        private ArrayList listaUsuarios;

        public Usuarios()
        {
            listaUsuarios = new ArrayList();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }

        public void EliminarUsuario(int indice)
        {
            if (indice >= 0 && indice < listaUsuarios.Count)
            {
                listaUsuarios.RemoveAt(indice);
            }
        }

        public bool BuscarU(int id)
        {

            bool existe = false;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (Convert.ToInt32(usuario.id) == id)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public bool BuscarPorCorr(string correo)
        {

            bool existe = false;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.correo == correo)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public bool BuscarPorContra(string contra)
        {
            bool existe = false;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.contra == contra)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public Usuario ObtenerUsuario(int index)
        {
            if (index >= 0 && index < listaUsuarios.Count)
            {
                return (Usuario)listaUsuarios[index];
            }
            return null;
        }

        public void ActualizarUsuario(int index, Usuario usrMod)
        {
            if (index >= 0 && index < listaUsuarios.Count)
            {
                listaUsuarios[index] = usrMod;
            }
        }
    }
}
