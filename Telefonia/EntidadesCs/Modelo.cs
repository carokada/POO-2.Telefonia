using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Modelo
   {
      private Marca marca; // asoc simple marca
      private string nombre;

      public Modelo(string nombre, Marca marca)
      {
         Nombre = nombre;
         Marca = marca;
      }

      public string Nombre
      {
         get => nombre;
         set
         {
            if (value.Length < 0 || value.Length > 50)
               throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
            nombre = value;
         }
      }

      public Marca Marca
      {
         get => marca;
         set => marca = value ?? throw new ArgumentException(" la marca no puede ser nula.");
      }

      public override string ToString()
      {
         return $"{marca} {Nombre}";
      }
   }
}
