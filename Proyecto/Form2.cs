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
       // private Usuarios usuarios = new Usuarios();
        private int selectedIndex = -1;
        private bool clikMod = false;
        private Usuarios usuarios;
        public Form2()
        {
            InitializeComponent();
            usuarios = UsuariosData.ListaUsuarios; // Acceder a la lista de usuarios compartida
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
            bool esValido = true;
            // Validar que el ID solo contenga números
            if (textID.Text != "" &!int.TryParse(textID.Text, out _))
            {
                MessageBox.Show("El ID debe ser un numero");
                esValido= false;
                idCorrecto = false;
            }


            if ( textNombre.Text != "" & textApellido.Text != "" & textCorreo.Text != "" & textFecha.Text != "" & textContrasena.Text != "" & idCorrecto)
            {
                
                int id = Convert.ToInt32(textID.Text);

                string correo = textCorreo.Text;
                
                

                // Validar que el nombre y apellido no tengan más de 50 caracteres
                if (textNombre.Text.Length > 50 || textApellido.Text.Length > 50)
                {
                    MessageBox.Show("El nombre y apellido no deben tener más de 15 caracteres.");
                    esValido= false;
                }

                // Validar que el correo tenga un formato válido
                if (!Regex.IsMatch(textCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El correo no tiene un formato valido.");
                    esValido= false;
                }

                // Validar que el ID no se repita si estoy creando uno nuevo
                if (selectedIndex == -1 /*|| (selectedIndex != -1 && Convert.ToInt32(usuarios.ObtenerUsuario(selectedIndex).id) != id)*/)
                {
                    if (usuarios.BuscarU(id))
                    {
                        MessageBox.Show("El ID ya existe. Por favor, elige otro ID.");
                        esValido= false;
                    }
                }

                // Validar que el correo no se repita 
                if (!clikMod)
                {
                    if (usuarios.BuscarPorCorr(correo))
                    {
                        MessageBox.Show("Esta cuenta ya esta asociada a un usuario.");
                        esValido = false;
                    }
                }
                
            
                // Validar que la fecha tenga el formato dd/mm/aaaa
                if (!DateTime.TryParseExact(textFecha.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    MessageBox.Show("La fecha de nacimiento debe tener el formato dd/MM/yyyy.");
                    esValido = false;
                }
            }
            else
            {
                MessageBox.Show("faltan datos o esta mal el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
                

            

            return esValido;
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
