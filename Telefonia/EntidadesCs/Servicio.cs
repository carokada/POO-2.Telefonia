using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Servicio : IPlan // clase a refactorizar: servicio seria la virtual ? 
   {
      private List<Servicio> Consumos = new List<Servicio>(); // guarda los consumos del servicio ? 

      private uint Credito { get; set; }
      private decimal precio;

      // constructor por mas de que no se pueda instanciar ??
      public Servicio (decimal precio, uint credito)
      {
         Precio = precio;
         Credito = credito;
      }

      public decimal Precio
      {
         get => precio;
         set => precio = value >= 0 ? value : throw new ArgumentException(" el precio no puede ser menor a cero.");
      }

      public void NuevoConsumo(uint valor)
      {
         // add ?? 
      }

      public uint GetDisponible()
      {
         uint sumatoriaConsumos = 0;
         foreach (var consumo in Consumos)
         {
            sumatoriaConsumos += consumo.Credito;
         }
         return Credito - sumatoriaConsumos;
      }

      public string GetDisponibleToString()
      {
         return $"{GetDisponible()} de {ToString()}"; // cadena q concatena el disponible junto al texto "de" seguido del metodo tostring
      }

      public string GetConsumosToString()
      {
         return $""; // total de consumos en string
      }
   }
}
