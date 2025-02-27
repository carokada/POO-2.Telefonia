using System;

namespace EntidadesCs
{
   public class Marca
   {
      private string nombre;

      public Marca(string nombre)
      {
         Nombre = nombre;
      }

      public string Nombre
      {
         get => nombre;
         set
         {
            if (value.Length < 0 || value.Length > 30)
               throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
            nombre = value;
         }
      }

      public override string ToString()
      {
         return $"{Nombre}";
      }
   }
}
