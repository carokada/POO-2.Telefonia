using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Linea
   {
      private Equipo equipo; // asoc simple equipo
      public Cliente Cliente { get; set; } // asoc simple cliente
      public IPlan Plan { get; set; }

      public ushort CodigoArea { get; set; }
      public uint Numero { get; set; }

      // etiqueta readonly: no se puede cambiar el valor de la var (casi como una const) 
      // private set: se puede modificar pero solo a nivel de objeto.
      public string Estado { get; private set; }

      public Linea(ushort codigoArea, uint numero, Equipo equipo, Cliente cliente)
      {
         CodigoArea = codigoArea;
         Numero = numero;
         Equipo = equipo;
         Cliente = cliente;

         Reactivar();
      }

      public void Suspender()
      {
         Estado = "suspendida";
      }

      public void Reactivar()
      {
         Estado = "activa";
      }

      public Equipo Equipo
      {
         get => equipo;
         set => equipo = value ?? throw new ArgumentException(" el equipo no puede ser nulo.");
      }

      public override string ToString()
      {
         return $"{Cliente.Nombre}: {CodigoArea}-{Numero} {(Estado == "suspendida" ? $"({Estado})" : "")}";
      }
   }
}
