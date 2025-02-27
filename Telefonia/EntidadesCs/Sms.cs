using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Sms : Servicio
   {
      public Sms(decimal precio, uint credito) : base(precio, credito) { }

      public override string ToString()
      {
         return $"{Credito} mensajes";
      }
   }
}
