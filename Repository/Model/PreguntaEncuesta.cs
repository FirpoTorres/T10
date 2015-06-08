using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    public class PreguntaEncuesta
    {
        private int idPreguntaEncuesta;
        private int idTipoEncuesta;
        private string pregunta;
        private int idSeleccion;
        private List<ElementoSeleccion> opciones = new List<ElementoSeleccion>();

        #region Propiedades
        public int IdPreguntaEncuesta
        {
            get { return idPreguntaEncuesta; }
            set { idPreguntaEncuesta = value; }
        }

        public int IdTipoEncuesta
        {
            get { return idTipoEncuesta; }
            set { idTipoEncuesta = value; }
        }

        public string Pregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }
        public int IdSeleccion
        {
            get { return idSeleccion; }
            set { idSeleccion = value; }
        }

        public List<ElementoSeleccion> Opciones
        {
            get { return opciones; }
            set { opciones = value; }
        }

        #endregion
    }        
}
