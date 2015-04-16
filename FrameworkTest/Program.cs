using System;
using System.Collections.Generic;
using System.Text;
using Repository.Model;



namespace FrameworkTest {
  class Program {
    static void Main(string[] args) {
        Demo de = new Demo();
        de.MyProperty = 1;
        Console.WriteLine(de.MyProperty.ToString());

        Console.ReadKey();


    }
  }
}
