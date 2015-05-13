using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Clase
{
    class elementoSeleccion
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

        
        public string Descripcion
        {
            
            get
            {
                return descripcion;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    descripcion = value;
                }
                else
                {
        }

    }    

}

