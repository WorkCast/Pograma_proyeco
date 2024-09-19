using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Intereses
    {
        public Etiqueta etiqueta1 { get; set; } // Relación con la clase Etiqueta
        public Etiqueta etiqueta2 { get; set; }
        public Etiqueta etiqueta3 { get; set; }

        public Intereses(Etiqueta etiqueta1, Etiqueta etiqueta2, Etiqueta etiqueta3)
        {
            this.etiqueta1 = etiqueta1;
            this.etiqueta2 = etiqueta2;
            this.etiqueta3 = etiqueta3;
        }

        public Intereses()
        {
            
        }
        public string MostrarIntereces()
        {
            string etiquetas = "";

            // Validar si las etiquetas existen y concatenarlas
            if (etiqueta1 != null) etiquetas += etiqueta1.nombre;
            if (etiqueta2 != null) etiquetas += " - " + etiqueta2.nombre;
            if (etiqueta3 != null) etiquetas += " - " + etiqueta3.nombre;

            return etiquetas;
        }
        public void CambiarEtiqueta(int numEti, Etiqueta nuevaEti)
        {


            // Cambiar la etiqueta correspondiente si no está vacía
            switch (numEti)
            {
                case 1:
                    if (etiqueta1 != null)
                    {
                        etiqueta1 = nuevaEti;
                    }
                    break;
                case 2:
                    if (etiqueta2 != null)
                    {
                        etiqueta2 = nuevaEti;
                    }
                    break;
                case 3:
                    if (etiqueta3 != null)
                    {
                        etiqueta3 = nuevaEti;
                    }
                    break;
            }
        }
        public bool ValidarEtiqueta(int numEti, Etiqueta eti)
        {
            bool valido = false;
            if (numEti>0||numEti<4)
            {
                if (eti!=null)
                {
                    valido = true;
                }
            }
            return valido;
        }
        public void BorrarEtiqueta(int numEti)
        {
            if (numEti > 0 || numEti < 4)
            {
                switch (numEti)
                {
                    case 1:
                            etiqueta1 = null;
                        break;
                    case 2:
                            etiqueta2 = null;
                        break;
                    case 3:
                            etiqueta3 = null;
                        break;
                }
            }
        }

       

    }
}
