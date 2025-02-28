using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Dato : Servicio
   {
      public Dato(decimal precio, uint credito) : base(precio, credito) { }

      public override void NuevoConsumo(uint valor)
      {
         // conversiones de mb a byte ?? 
         consumos.Add(valor);
      }

      public override string ToString()
      {
         return $"{Credito} Mbytes";
      }
   }
}
