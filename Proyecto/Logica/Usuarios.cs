using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Proyecto
{
    public class Usuarios
    {
        public ArrayList listaUsuarios;
        public Random random = new Random();

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

        public void EliminarUsrID(int id)
        {
            Usuario usuario = ObtenerUsuarioId(Convert.ToString( id));
            if (usuario != null)
            {
                listaUsuarios.Remove(usuario);
                
            }
            
        }

        public void MostrarTodosLosUsuarios()
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                Console.WriteLine(usuario.MostrarU());
            }
        }

        public string MostrarStringUsers()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuario usuario in listaUsuarios)
            {
                sb.AppendLine(usuario.MostrarU());
            }

            return sb.ToString();
        }

        public bool ExisteUser(int id)
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

        public Usuario ObtenerPorCorr(string correo)
        {

            

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.correo == correo)
                {
                    return usuario;
                }
            }
            return null;
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

        public Usuario ObtenerUsuarioId(string userId)
        {
            foreach (Usuario us  in listaUsuarios)
            {
                if (us.id == userId)
                {
                    return us;
                }
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

        //Validaciones de entradas 

        public bool ValidarIDNumerico(string idText)
        {
            if (!int.TryParse(idText, out _))
            {
                //MessageBox.Show("El ID debe ser un número.");
                return false;
            }
            return true;
        }

        public bool ValidarNombreApellido(string nombre, string apellido)
        {
            if (nombre.Length > 50 || apellido.Length > 50)
            {
                //MessageBox.Show("El nombre y apellido no deben tener más de 50 caracteres.");
                return false;
            }
            return true;
        }

        public bool ValidarCorreoFormato(string correo)
        {
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                //MessageBox.Show("El correo no tiene un formato válido.");
                return false;
            }
            return true;
        }

        public bool ValidarIDUnico(int id)
        {
            if (ExisteUser(id))
            {
                //MessageBox.Show("El ID ya existe. Por favor, elige otro ID.");
                return false;
            }
            return true;
        }

        public bool ValidarCorreoUnico(string correo)
        {
            if (BuscarPorCorr(correo))
            {
                //MessageBox.Show("Esta cuenta ya está asociada a un usuario.");
                return false;
            }
            return true;
        }

        public bool ValidarFechaFormato(string fecha)
        {
            if (!DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                //MessageBox.Show("La fecha de nacimiento debe tener el formato dd/MM/yyyy.");
                return false;
            }
            return true;
        }

        public ArrayList GetUsuarios()
        {
            return listaUsuarios;
        }

        public bool ValidarEntradas(string idText, string nombre, string apellido, string correo, string fecha, string contrasena, int selectedIndex, bool clikMod)
        {
            bool esValido = true;

            if (!ValidarIDNumerico(idText))
            {
                esValido = false;
            }

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(contrasena))
            {
                //MessageBox.Show("Faltan datos o está mal el ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }

            if (!ValidarNombreApellido(nombre, apellido))
            {
                esValido = false;
            }

            if (!ValidarCorreoFormato(correo))
            {
                esValido = false;
            }
            /*
            int id = Convert.ToInt32(idText);

            if (selectedIndex == -1 /*|| (selectedIndex != -1 && Convert.ToInt32(usuarios.ObtenerUsuario(selectedIndex).id) != id))
            {
                if (!ValidarIDUnico(id))
                {
                    esValido = false;
                }
            }
            */
            if (!clikMod)
            {
                if (!ValidarCorreoUnico(correo))
                {
                    esValido = false;
                }
            }

            if (!ValidarFechaFormato(fecha))
            {
                esValido = false;
            }

            return esValido;
        }
        public bool ValidarEntradas2(string idText, string nombre, string apellido, string correo, string fecha, string contrasena)
        {
            bool esValido = true;

            if (!ValidarIDNumerico(idText))
            {
                esValido = false;
            }

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(contrasena))
            {
                //MessageBox.Show("Faltan datos o está mal el ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }

            if (!ValidarNombreApellido(nombre, apellido))
            {
                esValido = false;
            }

            if (!ValidarCorreoFormato(correo))
            {
                esValido = false;
            }

            int id = Convert.ToInt32(idText);


            if (!ValidarFechaFormato(fecha))
            {
                esValido = false;
            }

            return esValido;
        }
        public int NuevoIdUser()
        {
            int id = 0;
            //genero un id aleatorio que aun no exista
            do
            {
                id = random.Next(1, int.MaxValue);
            } while ( ExisteUser(id));
            Console.WriteLine(id + " nuevo id");// nuevo id
            return id;
        }
    }
}
