	using System;
	using System.Collections.Generic;
	using System.Text;

namespace Repository.Model
{
    class Seleccion
    {
        private string descripcion;

        public void SetDescripcion(string value)
        {
            if (value.Length >= 256)
            {
                descripcion = value.Substring(0, 256);
            }
            else
            {
                descripcion = value;
            }
        }

        public string GetDescripcion()
        {
            return descripcion;
        }


        private int idSeleccion;

        public int IDseleccion
        {
            get { return idSeleccion; }
            set { idSeleccion = value; }
        }

    }

}