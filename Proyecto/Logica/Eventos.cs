using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto
{
    public class Eventos
    {
        // Atributos
        public ArrayList listaEventos { get; set; } = new ArrayList();
        public Random random { get; set; } = new Random();

        //valida la fecha
        public bool ValidarFechaHoraFormato(string fechaHora)
        {
            // Validar el formato de fecha y hora: "dd/MM/yyyy HH:mm"
            if (!DateTime.TryParseExact(fechaHora, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
            {
                return false;
            }
            return true;
        }

        // Método para generar un ID único
        public int NuevoId()
        {
            int id;
            do
            {
                id = random.Next(1, int.MaxValue);
            }
            while (ExisteEvento(id)); // Evitar colisiones de ID
            return id;
        }

        // Método para agregar un evento
        public void AgregarEvento(Evento evento)
        {
            //evento.idEvento = NuevoId(); // Asignar ID único
            listaEventos.Add(evento);
        }

        // Método para obtener un evento por ID
        public Evento ObtenerEventoPorId(int idEvento)
        {
            foreach (Evento evento in listaEventos)
            {
                if (evento.idEvento == idEvento)
                {
                    return evento;
                }
            }
            return null; // Retorna null si no encuentra el evento
        }

        // Método para eliminar un evento por ID
        public void EliminarEvento(int idEvento)
        {
            
            Evento eventoAEliminar = ObtenerEventoPorId(idEvento);
            if (eventoAEliminar != null)
            {
                listaEventos.Remove(eventoAEliminar);
                
            }
            
        }

        // Método para modificar un evento
        public void ModificarEvento(int idEvento, string nuevaDescripcion, string nuevoNombre,string lug, string fechaH, string nuevaDirImagen)
        {
            //Evento eventoMod = ObtenerEventoPorId(idEvento);
            if (ObtenerEventoPorId(idEvento) != null)
            {
                ObtenerEventoPorId(idEvento).descripcion = nuevaDescripcion;
                ObtenerEventoPorId(idEvento).nombre = nuevoNombre;
                ObtenerEventoPorId(idEvento).lugar =lug;
                ObtenerEventoPorId(idEvento).fechaEvento=fechaH;
                ObtenerEventoPorId(idEvento).dirImagen = nuevaDirImagen;
                
            }
            
        }

        // Método para verificar si un evento existe por su ID
        public bool ExisteEvento(int idEvento)
        {
            foreach (Evento evento in listaEventos)
            {
                if (evento.idEvento == idEvento)
                {
                    return true; // El evento existe
                }
            }
            return false; // El evento no existe
        }

        public string MostrarEventos()
        {
            string muestra="";
            foreach (Evento evento in listaEventos)
            {
                muestra += " "+evento.MostrarEvento();
            }
            return muestra; // El evento no existe
        }
    }
}
