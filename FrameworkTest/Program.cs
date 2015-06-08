using System;
using System.Collections.Generic;
using System.Text;
using Repository.Model;
using Repository;


namespace FrameworkTest {
  class Program {
    static void Main(string[] args) {
        
        //PABLO SOLIGO
        //Probando Cache de usuario en el repositorio


        ContextRepository cx = new ContextRepository(Properties.Settings.Default.AccessConnectionString);
        List<Usuario> lu1 = cx.GetUsuarios();

        int cantidad1 = lu1.Count;
        
        //vuelvo a pedir los usuarios la cantidad tiene que ser la misma si funciona el cache
        List<Usuario> lu2 = cx.GetUsuarios();

        if(lu1.Count!=lu2.Count){
            Console.WriteLine("ERROR, Cache de usuario no esta funcionando");
        }


        //Visualizo lo usuarios para mejor control
        foreach(Usuario u in lu2){
            Console.WriteLine(u.Login+", "+u.Nombre);
        }

        foreach(TipoEncuesta te in cx.GetTiposEncuesta()){
            Console.WriteLine(te.Nombre);
        }
       

        Console.ReadKey();


    }
  }
}
