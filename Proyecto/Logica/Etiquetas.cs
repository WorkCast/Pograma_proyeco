using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto
{
    public class Etiquetas
    {
        public ArrayList listEtiquetas;

        public Etiquetas()
        {
            listEtiquetas = new ArrayList();
        }

        // Método para agregar una etiqueta
        public void AgregarEtiqueta(Etiqueta etiqueta)
        {
            listEtiquetas.Add(etiqueta);
        }

        public void CargarEtiquetas()
        {
            //a futuro esto cargara las etiquetas de la base de datos
            Etiqueta eti1 = new Etiqueta("1", "Lugares cerrados");
            Etiqueta eti2 = new Etiqueta("2", "Lugares abiertos");
            Etiqueta eti3 = new Etiqueta("3", "Cerros");
            Etiqueta eti4 = new Etiqueta("4", "Patrimonio");
            Etiqueta eti5 = new Etiqueta("5", "Parques");
            Etiqueta eti6 = new Etiqueta("6", "Playas");
            Etiqueta eti7 = new Etiqueta("7", "Camping");
            Etiqueta eti8 = new Etiqueta("8", "Teatros/Cines");
            Etiqueta eti9 = new Etiqueta("9", "Estancias");
            Etiqueta eti10 = new Etiqueta("10", "Restaurantes/bares");
            Etiqueta eti11 = new Etiqueta("11", "Zoológicos");
            Etiqueta eti12 = new Etiqueta("12", "Mercados/ferias");
            Etiqueta eti13 = new Etiqueta("13", "Shopping");
            Etiqueta eti14 = new Etiqueta("14", "Museos");
            Etiqueta eti15 = new Etiqueta("15", "Monumentos");
            Etiqueta eti16 = new Etiqueta("16", "Parroquias/Iglesias");

            // Agregar etiquetas a la lista
            listEtiquetas.Add(eti1);
            listEtiquetas.Add(eti2);
            listEtiquetas.Add(eti3);
            listEtiquetas.Add(eti4);
            listEtiquetas.Add(eti5);
            listEtiquetas.Add(eti6);
            listEtiquetas.Add(eti7);
            listEtiquetas.Add(eti8);
            listEtiquetas.Add(eti9);
            listEtiquetas.Add(eti10);
            listEtiquetas.Add(eti11);
            listEtiquetas.Add(eti12);
            listEtiquetas.Add(eti13);
            listEtiquetas.Add(eti14);
            listEtiquetas.Add(eti15);
            listEtiquetas.Add(eti16);
        }

        // Método para buscar una etiqueta por id y devolver el objeto Etiqueta
        public Etiqueta BuscarPorId(string id)
        {
            foreach (Etiqueta etiqueta in listEtiquetas)
            {
                if (etiqueta.id == id)
                {
                    return etiqueta;
                }
            }
            return null; // Retorna null si no se encuentra la etiqueta
        }

        // Método para verificar si una etiqueta existe por id
        public bool ExisteEtiqueta(string id)
        {
            foreach (Etiqueta etiqueta in listEtiquetas)
            {
                if (etiqueta.id == id)
                {
                    return true;
                }
            }
            return false; // Retorna false si no se encuentra la etiqueta
        }

        // Método para eliminar una etiqueta por id si existe
        public void EliminarEtiqueta(string id)
        {
            if (ExisteEtiqueta(id))
            {
                Etiqueta etiquetaAEliminar = BuscarPorId(id);
                if (etiquetaAEliminar != null)
                {
                    listEtiquetas.Remove(etiquetaAEliminar);
                }
            }
        }
    }
}
