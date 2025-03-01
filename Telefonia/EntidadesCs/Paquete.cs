using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Paquete : IPlan
   {
      private List<Servicio> servicios; // asoc multiple servicio

      private decimal precio; // IPlan
      private string nombre;

      public Paquete()
      {
         servicios = new List<Servicio>();
      }

      public decimal Precio
      {
         get => precio;
         private set => precio = value >= 0 ? value : throw new ArgumentException(" el precio no puede ser menor a cero.");
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length > 0 ? value : throw new ArgumentException(" el nombre no puede estar vacio.");
      }

      public void AddServicio(Servicio servicio)
      {
         if (servicio == null)
            throw new ArgumentException(" el servicio no puede ser nulo.");
         if (servicios.Contains(servicio))
            throw new ArgumentException(" el servicio ya ha sido agregado a la lista.");
         servicios.Add(servicio);
      }

      public List<Servicio> GetAllServicios()
      {
         return servicios;
      }

      public void RemoveServicio(Servicio servicio)
      {
         if (servicio == null)
            throw new ArgumentException(" el servicio no puede ser nulo.");
         if (!servicios.Contains(servicio))
            throw new ArgumentException(" el servicio no ha sido agregado a la lista.");
         servicios.Remove(servicio);
      }

      public string GetDisponibleToString() //IPlan
      {
         string disponibles = "";
         foreach (var servicio in servicios)
         {
            disponibles += " ->" + servicio.GetDisponibleToString() + "\n";
         }
         return $"{disponibles}"; // cadena q concatena el rtdo del metodo homonimo de los serv asociados
      }

      public string GetConsumosToString() //IPlan
      {
         string consumos = "";
         foreach (var servicio in servicios)
         {
            consumos += " ->" + servicio.GetConsumosToString() + "\n";
         }
         return $"{consumos}"; // total de consumos en string
      }
   }
}
