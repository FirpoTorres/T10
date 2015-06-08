using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Model
{
    public class Respuesta
    {
        private int idPregunta;
        private int idEncuesta;
        private string pregunta;
        private string respuesta;

        #region Propiedades

        public string Respuesta
        {
            get { return respuesta; }

            set
            {
                if (value.Length > 512)
                { respuesta = value.Substring(0, 511); }
                else
                { respuesta = value; }
            }
        }

        public string Pregunta
        {
            get { return pregunta; }

            set
            {
                if (value.Length > 512)
                    pregunta = value.Substring(0, 511);
                else
                    pregunta = value;
            }
        }

        public int IdPregunta
        {
            get { return idPregunta; }
            set { idPregunta = value; }
        }

        public int IdRespuesta
        {
            get { return idEncuesta; }
            set { idEncuesta = value; }
        }

        #endregion
    }
}