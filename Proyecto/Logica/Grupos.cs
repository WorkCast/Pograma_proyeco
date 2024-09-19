using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto
{
    public class Grupos
    {
        public ArrayList grupos { get; set; } = new ArrayList();
        public Random random = new Random();

        // Método para agregar un grupo
        public void AgregarGrupo(Grupo grupo)
        {
            grupos.Add(grupo);
        }

        // Método para eliminar un grupo por ID
        public void EliminarGrupo(int id)
        {
            Grupo grupo = ObtenerPorId(id);
            if (grupo != null)
            {
                grupos.Remove(grupo);
            }
        }

        public void ModificarGrupo(int idGrupo, string nom, string descGrupo, string dirImg,Intereses inte)
        {
            if (ObtenerPorId(idGrupo)!=null)
            {
                ObtenerPorId(idGrupo).nombre = nom;
                ObtenerPorId(idGrupo).descripcion = descGrupo;
                ObtenerPorId(idGrupo).dirImagen = dirImg;
                ObtenerPorId(idGrupo).intereses = inte;
            }
            
        }

        // Método para obtener un grupo por ID
        public Grupo ObtenerPorId(int id)
        {
            foreach (Grupo grupo in grupos)
            {
                if (grupo.id == id)
                {
                    return grupo;
                }
            }
            return null;
        }

        // Método para verificar si un grupo existe por ID
        public bool ExisteGrupo(int grupoId)
        {
            bool existe = false;
            foreach (Grupo grupo in grupos)
            {
                if (grupo.id == grupoId)
                {
                    existe = true;
                    break; // Salimos del bucle si ya encontramos el grupo
                }
            }
            return existe;
        }
        public int NuevoIdGrupo()
        {
            int id = 0;
            // Genera un ID aleatorio que aún no exista en los grupos
            do
            {
                id = random.Next(1, int.MaxValue);
            } while (ExisteGrupo(id)); // Verifica si el ID ya existe
            Console.WriteLine(id + " nuevo id grupo"); // Imprime el nuevo ID generado
            return id;
        }
    }
}
