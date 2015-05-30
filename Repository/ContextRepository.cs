using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using Repository.Model;

namespace Repository {



    public class ContextRepository {
        private String ConnectionString;

        public ContextRepository(String cs) {
            ConnectionString = cs;

        }


        public List<Usuario> GetUsuarios() {
            return null;
        }



        public Usuario NuevoUsuario() {
            return null;
        }

        public Usuario GetUsuario(String Login) {
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
