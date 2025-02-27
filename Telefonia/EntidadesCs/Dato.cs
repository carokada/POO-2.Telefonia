using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Dato : Servicio
   {
      public Dato(decimal precio, uint credito) : base(precio, credito) { }

      //public override uint NuevoConsumo(); ??

      public override string ToString()
      {
         return $"{Credito} Mbytes";
      }
   }
}
