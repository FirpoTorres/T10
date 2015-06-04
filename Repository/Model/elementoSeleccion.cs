using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model {
  public class ElementoSeleccion {

    private String descripcion;

    
    public ElementoSeleccion()
      : base() {
      idElementoSeleccion = -1;
    }

    public ElementoSeleccion(int Key)
      : base() {
      idElementoSeleccion = Key;
    }

    public String Descripcion {
      get { return descripcion; }
      set { descripcion = value; }
    }

    private int? idSeleccion;

    public int? IdSeleccion {
      get { return idSeleccion; }
      set { idSeleccion = value; }
    }

    private int idElementoSeleccion;

    public int IdElementoSeleccion {
      get { return idElementoSeleccion; }
      set { idElementoSeleccion = value; }
    }



  }
}
