using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using Repository.Model;

namespace Repository {



    public class ContextRepository {
        private String ConnectionString;

        //Lista de usuarios precargados, cuando el contexto retorna algo
        //debe guardar la referencia para poder salvarlo posteriorme.
        //Si se vuelve a pedir por el mismo elemento se toma de la lista y no se
        //vuelve a consultar a la base de datos

        private List<Usuario> lu = new List<Usuario>();

        public ContextRepository(String cs) {
            ConnectionString = cs;

        }


        public List<Usuario> GetUsuarios() {


            //Existen varias formas de resolver esto, como es la tabla usuario que se presume pequeña traigo
            //todos los registros inserto en la lista que un metodo especial que preguntara si el objeto existe o no.
            //Se veran mas adelante formas mas inteligentes de hacer esto esto

            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from Usuario", conn);
            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) {

                while (dr.Read()) {
                    Usuario u = new Usuario();
                    u.Login = dr["Login"].ToString();
                    u.Password = dr["Password"].ToString();
                    u.Nombre = dr["Nombre"].ToString();
                    AddToList(u);
                };

            } else {

            }
            return lu;

        }



        private void AddToList(Usuario u) {
            //busco si el usuario existe, sino lo agrego a la lista
            //.Net tiene formas mejores de realizar esto, en lugar de busqueda secuencial
            //Se pueden utilizar metodos anonimos y el metodo find de la lista
            Boolean encontrado = false;
            foreach (Usuario usuarioenlista in lu) {
                if (usuarioenlista.Login == u.Login) {
                    //Existe, no hay nada que hacer por ahora
                    encontrado = true;
                } else {

                    //No existe debo agregar a mi lista
                    
                }
            }

            if (!encontrado) {
                lu.Add(u);
            }



        }



        public Usuario NuevoUsuario() {
            return null;
        }

        public Usuario GetUsuario(String Login) {
            
            //Tarea para el grupo: Aplicar la tecnica de lista cache en este metodo tambien
            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from Usuario Where Login=@Login", conn);
            comm.Parameters.AddWithValue("@Login", Login);

            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) {
                dr.Read();
                Usuario Result = new Usuario();


                Result.Login = dr["Login"].ToString();
                Result.Password = dr["Password"].ToString();
                Result.Nombre = dr["Nombre"].ToString();

                return Result;
            }
            return null;

        }
    }
}
