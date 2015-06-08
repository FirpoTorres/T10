using System;
using System.Collections.Generic;

using System.Text;

namespace Repository.Model
{
    public class TipoEncuesta
    {
        private int idTipoEncuesta;
        private string nombre;

        #region Propiedades

        public int IdTipoEncuesta
        {
            get { return idTipoEncuesta; }
            set { idTipoEncuesta = value; }
        }

        public string Nombre
        {
            get { return nombre; }

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

        #endregion
    }
}
