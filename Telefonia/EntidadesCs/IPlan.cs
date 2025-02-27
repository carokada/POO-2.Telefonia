using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public interface IPlan
   {
      decimal Precio { get; }

      string GetDisponibleToString();
      string GetConsumosToString();
   }
}
