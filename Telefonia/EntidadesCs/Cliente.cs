using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Cliente
   {
      public string Nombre { get; set; }

      public Cliente (string nombre)
      {
         Nombre = nombre;
      }
   }
}
