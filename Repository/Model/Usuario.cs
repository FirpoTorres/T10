using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    class Usuario
    {
        private string nombre;

        public void SetNombre(string value){ /*crear el nombre del usuario*/
            if (value.Length >= 128){ /*si tiene mas de 128 caracteres imprime un mensaje de error*/
                nombre = value.Substring(0, 128);
            }else{
                nombre = value; 
            }
        }

        public string GetNombre(){ /*devolver el nombre del usuario*/
            return nombre;}


        private string login;
        public void SetLogin(string value){ /*crear el login del usuario*/
            if (value.Length >= 20){ /*si es mayor a 20 caracteres imprime un mensaje de error*/
                login = value.Substring(4, 20);
            }else{
                login = value; 
            }
        }

        public string GetLogin()
        { /*devuelve el login del usuario*/
            return login;
        }


        private string password;
        public void SetPassword(string value)
        { /*crear el password del usuario*/
            if (value.Length >= 20)
            { /*si el password es mayor a 20 caracteres imprime un mensaje de error*/
                password = value.Substring(4, 20);
            }
            else
            {
                password = value; 
            }

                private string SimEncrypt(string password);
{

    StringBuilder inSb = new StringBuilder(password);
    StringBuilder outSb = new StringBuilder(password.Length);

    char c;

    for (int i = 0; i < password.Length; i++)
    {
        c = inSb[i];
        c = (char)(c ^ (char)ClaveInterna[(i+4)%4]);
        outSb.Append(c);

    }

    return outSb.ToString();

}
        }

    }

}
