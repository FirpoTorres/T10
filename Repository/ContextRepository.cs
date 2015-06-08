using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using Repository.Model;

namespace Repository
{

    public class ContextRepository
    {
        private String ConnectionString;

        //Lista de usuarios precargados, cuando el contexto retorna algo
        //debe guardar la referencia para poder salvarlo posteriorme.
        //Si se vuelve a pedir por el mismo elemento se toma de la lista y no se
        //vuelve a consultar a la base de datos

        private List<Usuario> lu = new List<Usuario>();
        private List<Seleccion> ls = new List<Seleccion>();
        private List<ElementoSeleccion> les = new List<ElementoSeleccion>();

        public ContextRepository(String cs)
        {
            ConnectionString = cs;
        }

        #region Usuario

        public List<Usuario> GetUsuarios()
        {
            //Existen varias formas de resolver esto, como es la tabla usuario que se presume pequeña traigo
            //todos los registros inserto en la lista que un metodo especial que preguntara si el objeto existe o no.
            //Se veran mas adelante formas mas inteligentes de hacer esto esto

            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from Usuario", conn);
            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.Login = dr["Login"].ToString();
                    u.Password = dr["Password"].ToString();
                    u.Nombre = dr["Nombre"].ToString();
                    AddToList(u);
                };
            }
            else
            {

            }
            return lu;
        }

        private void AddToList(Usuario u)
        {
            //busco si el usuario existe, sino lo agrego a la lista
            //.Net tiene formas mejores de realizar esto, en lugar de busqueda secuencial
            //Se pueden utilizar metodos anonimos y el metodo find de la lista
            Boolean encontrado = false;
            foreach (Usuario usuarioenlista in lu)
            {
                if (usuarioenlista.Login == u.Login)
                {
                    //Existe, no hay nada que hacer por ahora
                    encontrado = true;
                }
                else
                {

                    //No existe debo agregar a mi lista

                }
            }

            if (!encontrado)
            {
                lu.Add(u);
            }
        }

        public Usuario NuevoUsuario()
        {
            return null;
        }

        public Usuario GetUsuario(String Login)
        {
            //Tarea para el grupo: Aplicar la tecnica de lista cache en este metodo tambien
            foreach (Usuario u in lu)
            {
                if (u.Login == Login)
                    return u;
            }
            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from Usuario Where Login=@Login", conn);
            comm.Parameters.AddWithValue("@Login", Login);

            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Usuario Result = new Usuario();

                Result.Login = dr["Login"].ToString();
                Result.Password = dr["Password"].ToString();
                Result.Nombre = dr["Nombre"].ToString();
                AddToList(Result);
                return Result;
            }
            return null;
        }

        #endregion

        #region Elemento Seleccion

        public List<ElementoSeleccion> GetElementoSeleccion()
        {
            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from ElementoSeleccion", conn);
            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ElementoSeleccion es = new ElementoSeleccion();
                    es.Descripcion = dr["Descripcion"].ToString();
                    es.IdElementoSeleccion = (int)dr["IdElementoSeleccion"];
                    es.IdSeleccion = (int)dr["IdSeleccion"];
                    agregarElementoSeleccion(es);
                };
            }
            return les;
        }

        private void agregarElementoSeleccion(ElementoSeleccion es)
        {
            Boolean encontrado = false;
            foreach (ElementoSeleccion elemento in les)
            {
                if (es.Descripcion == elemento.Descripcion)
                    encontrado = true;
            }
            if (!encontrado)
                les.Add(es);
        }

        public ElementoSeleccion GetElementoSeleccion(int id)
        {
            foreach (ElementoSeleccion elemento in les)
            {
                if (elemento.IdSeleccion == id)
                    return elemento;
            }
            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from ElementoSeleccion Where IdElementoSeleccion=@Id", conn);
            comm.Parameters.AddWithValue("@Id", id);

            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                ElementoSeleccion res = new ElementoSeleccion();

                res.Descripcion = dr["Descripcion"].ToString();
                res.IdElementoSeleccion = (int)dr["IdElementoSeleccion"];
                res.IdSeleccion = (int)dr["IdSeleccion"];
                agregarElementoSeleccion(res);
                return res;
            }
            return null;
        }

        #endregion

        #region Seleccion

        public List<Seleccion> GetSelecciones()
        {
            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Y aca va esa hermosa consulta", conn);
            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Seleccion s = new Seleccion();
                    s.Descripcion = dr["Descripcion"].ToString();
                    s.IDseleccion = (int)dr["IdSeleccion"];
                    s.esl = (List<ElementoSeleccion>)dr["ElementoSeleccion"];
                    agregarSeleccion(s);
                };
            }
            return ls;
        }

        private void agregarSeleccion(Seleccion s)
        {
            Boolean encontrado = false;
            foreach (Seleccion sel in ls)
            {
                if (sel.IDseleccion == s.IDseleccion)
                    encontrado = true;
            }
            if (!encontrado)
            {
                ls.Add(s);
            }
        }

        public Seleccion GetSeleccion(int id)
        {
            foreach (Seleccion sel in ls)
            {
                if (sel.IDseleccion == id)
                    return sel;
            }
            OleDbConnection conn = new OleDbConnection(this.ConnectionString);
            conn.Open();
            OleDbCommand comm = new OleDbCommand("Select * from Seleccion where IdSeleccion=@Id", conn);
            comm.Parameters.AddWithValue("@Id", id);

            OleDbDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Seleccion res = new Seleccion();

                res.Descripcion = dr["Descripcion"].ToString();
                res.IDseleccion = (int)dr["Password"];
                res.esl = (List<ElementoSeleccion>)dr["ElementoSeleccion"];
                agregarSeleccion(res);
                return res;
            }
            return null;
        }
        #endregion
    }
}
