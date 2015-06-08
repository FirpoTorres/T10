using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    public class Encuesta
    
    {
        private int idEncuesta;
        private DateTime fechaHora;
        private int idTipoEncuesta;
        public List<PreguntaEncuesta> preguntas = new List<PreguntaEncuesta>(); 

        public int IdEncuesta
        {
            get { return idEncuesta; }
            set {  idEncuesta = value; }
        }        

        public int IdTipoEncuesta
        {
            get { return idTipoEncuesta; }
            set { idTipoEncuesta = value; }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = DateTime.UtcNow; }
        }   
    }
}

