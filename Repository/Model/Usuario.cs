﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model
{
    public class Usuario
    {
        private string nombre;
        private string login;
        private string password;
        private string ClaveInterna;

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length >= 128)
                {
                    nombre = value.Substring(0, 128);
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length >= 20)
                {
                    login = value.Substring(4, 20);
                }
                else
                {
                    login = value;
                }
            }

        }

        public string Password
        {
            //get { }
            set
            {
                if (value.Length >= 20)
                {
                    password = value.Substring(4, 20);
                }
                else
                {
                    password = value;
                }
            }

        }

        private string SimEncrypt(string password)
        {
            StringBuilder inSb = new StringBuilder(password);
            StringBuilder outSb = new StringBuilder(password.Length);
            char c;
            ClaveInterna = "aaaa";

            for (int i = 0; i < password.Length; i++)
            {
                c = inSb[i];
                c = (char)(c ^ (char)ClaveInterna[(i + 4) % 4]);
                outSb.Append(c);
            }
            return outSb.ToString();
        }
        #endregion

    }
}
    
  //PABLO SOLIGO: No subir codigo que no compila por favor!

        /* PABLO SOLIGO : Reparar esto no lo quiero hacer yo
         * Modifico codigo solo para compile 
        private string SimEncrypt(string password){
            
           
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
        */
    




