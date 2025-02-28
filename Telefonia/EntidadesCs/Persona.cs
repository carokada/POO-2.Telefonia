using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Persona : Cliente
   {
      public string Dni { get; set; }

      public Persona (string nombre, string dni) : base(nombre)
      {
         Dni = dni;
      }

      public override string ToString()
      {
         return $"{Nombre} ({Dni})";
      }
   }
}
