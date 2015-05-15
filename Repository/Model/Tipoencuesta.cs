using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Model
{
    public class Tipoencuesta
    {
        private int idtipoencuesta;
        private string nombre;

        /*--- PROPIEDADES ---*/

        public int Idtipoencuesta
        {
            get
            {
                return idtipoencuesta; 
                
            }
            set
            {
                idtipoencuesta = value; 
            }

        }

        public string Nombre
        {
            get
            {
                return nombre; 
            }

            set
            {
                if (value.Length > 128)
                {
                    nombre = value.Substring(0,127);
                }
                else
                {
                    nombre = value; 
                }
            }
        }
    }
}
