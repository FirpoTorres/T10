using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    public class Usuario
    {
        private string nombre;

        public void SetNombre(string value){ /*crear el nombre del usuario*/
            if (value.Length <= 128){ /*si tiene mas de 128 caracteres imprime un mensaje de error*/
                nombre = value.Substring(0, 128);
            }else{
                Console.WriteLine("ERROR: Nombre debe ser menor a 128 caracteres");
            }
        }

        public string GetNombre(){ /*devolver el nombre del usuario*/
            return nombre;}


        private string login;
        public void SetLogin(string value){ /*crear el login del usuario*/
            if (value.Length <= 20){ /*si es mayor a 20 caracteres imprime un mensaje de error*/
                login = value.Substring(0, 20);
            }else{
                Console.WriteLine("ERROR: Login debe ser menor a 20 caracteres");
            }
        }

        public string GetLogin(){ /*devuelve el login del usuario*/
            return login;
        }


        private string password;
        public void SetPassword(string value){ /*crear el password del usuario*/
            if (value.Length <= 20){ /*si el password es mayor a 20 caracteres imprime un mensaje de error*/
                password = value.Substring(0, 20);
            }else{
                Console.WriteLine("ERROR: Password debe ser menor a 20 caracteres");
            }
        }


    }
}
