using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Equipo
   {
      private Modelo modelo; // asoc simple modelo

      private string serie;
      public DateTime FechaVenta { get; private set; } // private set o readonly ?? diferencia ??

      public Equipo(Modelo modelo, string serie)
      {
         Modelo = modelo;
         Serie = serie;
      }

      public string Serie
      {
         get => serie;
         set
         {
            if (value.Length < 0 || value.Length > 15)
               throw new ArgumentException(" el nombre de la serie no cumple con los requerimientos del campo.");
            serie = value;
         }
      }

      public Modelo Modelo
      {
         get => modelo;
         set => modelo = value ?? throw new ArgumentException(" el modelo no puede ser nulo.");
      }

      public void Vender(DateTime fecha)
      {
         FechaVenta = fecha;
      }

      public override string ToString()
      {
         return $"[{serie}] {modelo}";
      }
   }
}
