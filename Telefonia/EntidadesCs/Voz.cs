using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Voz : Servicio
   {
      public Voz(decimal precio, uint credito) : base(precio, credito) { }

      public override string ToString()
      {
         return $"{Credito} minutos";
      }
   }
}
