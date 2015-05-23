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
        return null;
    }

  }
}
