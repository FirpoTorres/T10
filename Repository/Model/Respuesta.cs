using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Respuesta
    {
        private int idPregunta;
        private int idEncuesta;
        private string pregunta;
        private string respuesta;

        public string Funcion_respuesta
        {
            get {
                return respuesta;
                }

            set {
                if (value.Length > 512)
                { respuesta = value.Substring(0, 511); }
                else
                { respuesta = value; }
                }
        }

        public string Funcion_pregunta
        {
            get
            {
                return pregunta;
            }

            set
            {
                if (value.Length > 512)
                {
                    pregunta = value.Substring(0, 511);
                }
                else
                {
                    pregunta = value;
                }
            
            }
        }

        public int Id_Pregunta
        {
            get {
                return idPregunta;
                }

            set {
                idPregunta = value;
                }
        }

        public int Id_Respuesta
        {
            get
            {
                return idEncuesta;
            }

            set
            {
                idEncuesta = value;
            }
        }
   
    }

    }