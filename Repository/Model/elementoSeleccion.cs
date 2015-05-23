using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Model
{
    class ElementoSeleccion
    {
        
        private int IdElementoSeleccion;
        private int IdSeleccion;
        private string descripcion;

        public int idElementoSeleccion
        {
            get
            {
                return IdElementoSeleccion;
            }

            set
            {
                IdElementoSeleccion = value;
            }
        }

        
        public int idSeleccion
        {
            get
            {
                return IdSeleccion;
            }

            set
            {
                IdSeleccion = value;
            }

        }


        public string Descripcion {

            get {
                return descripcion;
            }

            set {
                if (string.IsNullOrEmpty(value)) {
                    descripcion = "Sin discripcion";
                } else {
                    descripcion = value;
                }
            }
            }

        }       

}

