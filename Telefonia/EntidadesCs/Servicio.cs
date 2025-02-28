using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Servicio : IPlan // clase a refactorizar: servicio seria la virtual ? 
   {
      // protected para que se pueda acceder desde datos (subclase)
      protected List<uint> consumos = new List<uint>(); // guarda los consumos del servicio ??

      public uint Credito { get; set; }
      private decimal precio;

      // metodo simil constructor
      protected Servicio (decimal precio, uint credito)
      {
         Precio = precio;
         Credito = credito;
      }

      public decimal Precio
      {
         get => precio;
         set => precio = value >= 0 ? value : throw new ArgumentException(" el precio no puede ser menor a cero.");
      }

      public virtual void NuevoConsumo(uint valor)
      {
         consumos.Add(valor);
      }

      private uint GetConsumos()
      {
         uint sumatoriaConsumos = 0;
         foreach (var consumo in consumos)
         {
            sumatoriaConsumos += consumo;
         }
         return sumatoriaConsumos;
      }

      public uint GetDisponible()
      {
         return Credito - GetConsumos(); 
      }

      public string GetDisponibleToString()
      {
         return $"{GetDisponible()} de {ToString()}"; // cadena q concatena el disponible junto al texto "de" seguido del metodo tostring
      }

      public string GetConsumosToString()
      {
         return $"{GetConsumos()} de {ToString()}"; // total de consumos en string
      }
   }
}
