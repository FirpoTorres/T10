using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    public class PreguntaEncuesta  //Plantilla
    {
        public int IdPreguntaEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string Pregunta { get; set; }
        public int IdSeleccion { get; set; }
        public List<ElementoSeleccion> Opciones = new List<ElementoSeleccion>();



    }
        
}
