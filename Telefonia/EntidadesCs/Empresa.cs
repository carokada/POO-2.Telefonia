using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Empresa :  Cliente
   {
      public string Cuit_cuil { get; set; }

      public Empresa (string nombre, string cuit_cuil) : base(nombre)
      {
         Cuit_cuil = cuit_cuil;
      }
   }
}
