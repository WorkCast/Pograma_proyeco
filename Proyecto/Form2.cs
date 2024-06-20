using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        private Usuarios usuarios = new Usuarios();
        private int selectedIndex = -1;
        private bool clikMod = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            selectedIndex = -1;
            listUsuarios.SelectedIndex = -1;
            string id = textID.Text;
            string nom = textNombre.Text;
            string apell = textApellido.Text;
            string correo = textCorreo.Text;
            string fechaN = textFecha.Text;
            string contra = textContrasena.Text;
            if (id != "" & nom != "" & apell != "" & correo != "" & fechaN != "" & contra != "")
            {
                if (ValidarEntradas())
                {
                    Usuario u = new Usuario(id, nom, apell, correo, fechaN,contra);

                    usuarios.AgregarUsuario(u);
                    listUsuarios.Items.Add(u.MostrarU());
                    textID.Clear();
                    textNombre.Clear();
                    textApellido.Clear();
                    textCorreo.Clear();
                    textFecha.Clear();
                    textContrasena.Clear();
                }
            }
            else
            {
                MessageBox.Show("Hay datos faltantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public class Usuario
        {
            public string id { get; set; }
            public string nom { get; set; }
            public string apell { get; set; }
            public string correo { get; set; }
            public string fechaN { get; set; }
            public string contra { get; set; }


            public Usuario(string id, string nom, string apell, string correo, string fechaN, string contra)
            {
                this.id = id;
                this.nom = nom;
                this.apell = apell;
                this.correo = correo;
                this.fechaN = fechaN;
                this.contra = contra;
            }
            public Usuario()
            {

            }
            public string MostrarU()
            {
                string textoUsr=this.id+" - "+this.nom+" - " +this.apell+" - "+this.correo+" - "+this.fechaN+" - "+this.contra;
                
                return textoUsr;
            }
        }

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
                        existe= true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("el orden de la informacion es el mismo que el de ingreso de datos, para eliminar debe hacer clic al usuario en la lista y cambiar datos de un usuario no cambia su id.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listUsuarios.SelectedIndex;
            /* funcion de cuando das clic en un usuario de la lista te rellene los textBox en progreso
            Usuario user = usuarios.ObtenerUsuario(selectedIndex);
            
            textID.Text = user.id;
            textNombre.Text = user.nom;
            textApellido.Text = user.apell;
            textCorreo.Text = user.correo;
            textFecha.Text = user.fechaN;
            textContrasena.Text = user.contra; //*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < listUsuarios.Items.Count)
            {
                usuarios.EliminarUsuario(selectedIndex);
                listUsuarios.Items.RemoveAt(selectedIndex);                
                selectedIndex = -1;
                listUsuarios.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Primero selecione un usuario a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarEntradas()
        {
            bool idCorrecto = true;
            bool validar = true;
            // Validar que el ID solo contenga números
            if (textID.Text != "" &!int.TryParse(textID.Text, out _))
            {
                MessageBox.Show("El ID debe ser un numero");
                validar= false;
                idCorrecto = false;
            }


            if ( textNombre.Text != "" & textApellido.Text != "" & textCorreo.Text != "" & textFecha.Text != "" & textContrasena.Text != "" & idCorrecto)
            {
                
                int id = Convert.ToInt32(textID.Text);

                string correo = textCorreo.Text;
                
                

                // Validar que el nombre y apellido no tengan más de 15 caracteres
                if (textNombre.Text.Length > 50 || textApellido.Text.Length > 50)
                {
                    MessageBox.Show("El nombre y apellido no deben tener más de 15 caracteres.");
                    validar= false;
                }

                // Validar que el correo tenga un formato válido
                if (!Regex.IsMatch(textCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El correo no tiene un formato valido.");
                    validar= false;
                }

                // Validar que el ID no se repita (excepto si es el mismo usuario siendo modificado)
                if (selectedIndex == -1 || (selectedIndex != -1 && Convert.ToInt32(usuarios.ObtenerUsuario(selectedIndex).id) != id))
                {
                    if (usuarios.BuscarU(id))
                    {
                        MessageBox.Show("El ID ya existe. Por favor, elige otro ID.");
                        validar= false;
                    }
                }

                // Validar que el correo no se repita y si esta el programa en modificacion
                if (!clikMod)
                {
                    if (usuarios.BuscarPorCorr(correo))
                    {
                        MessageBox.Show("Esta cuenta ya esta asociada a un usuario.");
                        validar = false;
                    }
                }
                
            
                // Validar que la fecha tenga el formato dd/mm/aaaa
                if (!DateTime.TryParseExact(textFecha.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    MessageBox.Show("La fecha de nacimiento debe tener el formato dd/MM/yyyy.");
                    validar = false;
                }
            }
            else
            {
                MessageBox.Show("faltan datos o esta mal el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
            }
                

            

            return validar;
        }



        private void textCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// /////////////////////////////////////////////////////////
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < listUsuarios.Items.Count)
            {
                clikMod = true;
                if (ValidarEntradas())
                {
                    Usuario userMod = usuarios.ObtenerUsuario(selectedIndex);

                    

                    //userMod.id = textID.Text;
                    userMod.nom = textNombre.Text;
                    userMod.apell = textApellido.Text;
                    userMod.correo = textCorreo.Text;
                    userMod.fechaN = textFecha.Text;
                    userMod.contra = textContrasena.Text;



                    ///////////
                    usuarios.EliminarUsuario(selectedIndex);
                    listUsuarios.Items.RemoveAt(selectedIndex);
                    ///////////
                    ///
                    usuarios.AgregarUsuario(userMod);
                    listUsuarios.Items.Add(userMod.MostrarU());
                    /*
                    // Actualizar el ArrayList de usuarios
                    usuarios.ActualizarUsuario(selectedIndex, userMod);

                    // Actualizar el ListBox
                    listUsuarios.Items[selectedIndex] = userMod.MostrarU();
                    */
                    // Limpiar los TextBoxes después de modificar

                    textID.Clear();
                    textNombre.Clear();
                    textApellido.Clear();
                    textCorreo.Clear();
                    textFecha.Clear();
                    textContrasena.Clear();

                    // Reiniciar el índice seleccionado
                    selectedIndex = -1;
                    listUsuarios.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Primero selecione un usuario a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clikMod = false;
        }
    }
}
