using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    public class PreguntaEncuesta  //PREGUNTAS ABIERTAS
    {
        private int idPreguntaEncuesta; //ATRIBUTO 1

        public int IDpreguntaencuesta
        {
            get
            {
                return idPreguntaEncuesta;
            }
            set
            {
                idPreguntaEncuesta = value;
            }
        }

        private int idTipoEncuesta; //ATRIBUTO 2

        public int IDtipoencuesta
        {
            get
            {
                return idTipoEncuesta;
            }
            set
            {
                idTipoEncuesta = value;
            }
        }

        private string pregunta;    //ATRUBUTO 3

        public void SetPregunta(string value)
        {
            if (value.Length >= 512)
            {
                pregunta = value.Substring(0, 512);
            }
            else
            {
                pregunta = value;
            }
        }

        public string GetPregunta()
        {
            return pregunta;
        }

        private int idSeleccion;    //ATRIBUTO 4

        public int IDseleccion
        {
            get
            {
                return idSeleccion;
            }
            set
            {
                idSeleccion = value;
            }
        }

    }
}
