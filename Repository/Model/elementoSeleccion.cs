using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Model {
  public class ElementoSeleccion 
  {

    private String descripcion;
    private int? idSeleccion;
    private int idElementoSeleccion;
    
    public ElementoSeleccion(): base() 
    {
      idElementoSeleccion = -1;
    }

    public ElementoSeleccion(int Key): base() 
    {
      idElementoSeleccion = Key;
    }

    #region Propiedades
    public String Descripcion 
    {
      get { return descripcion; }
      set { descripcion = value; }
    }

    public int? IdSeleccion 
    {
      get { return idSeleccion; }
      set { idSeleccion = value; }
    }

    public int IdElementoSeleccion 
    {
      get { return idElementoSeleccion; }
      set { idElementoSeleccion = value; }
    }
#endregion
  }
}
