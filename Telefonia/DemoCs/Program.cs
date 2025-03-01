using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";

         Console.WriteLine(" creando marcas...");
         Marca marca1 = new Marca("Samsung");
         Marca marca2 = new Marca("Motorola");
         Marca marca3 = new Marca("IPhone");
         Console.WriteLine("\n marcas cargadas: ");
         Console.WriteLine(marca1);
         Console.WriteLine(marca2);
         Console.WriteLine(marca3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando modelos...");
         Modelo modelo1 = new Modelo("Z Flip 6", marca1);
         Modelo modelo2 = new Modelo("Razr 50 Ultra", marca2);
         Modelo modelo3 = new Modelo("15", marca3);
         Console.WriteLine("\n modelos cargados: ");
         Console.WriteLine(modelo1);
         Console.WriteLine(modelo2);
         Console.WriteLine(modelo3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando equipos... ");
         Equipo equipo1 = new Equipo(modelo1, "123");
         Equipo equipo2 = new Equipo(modelo2, "124");
         Equipo equipo3 = new Equipo(modelo3, "125");
         Console.WriteLine("\n equipos cargados: ");
         Console.WriteLine(equipo1);
         Console.WriteLine(equipo2);
         Console.WriteLine(equipo3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando clientes...");
         Persona persona1 = new Persona("Juan Perez", "25963458");
         Persona persona2 = new Persona("Maria Velez", "19456284");
         Persona persona3 = new Persona("Roberta Gularte", "30167439");
         Empresa empresa1 = new Empresa("California", "123456789");
         Empresa empresa2 = new Empresa("Todo Frio", "123456789");
         Empresa empresa3 = new Empresa("Anyway", "123456789");
         Console.WriteLine("\n -> personas cargadas: ");
         Console.WriteLine(persona1);
         Console.WriteLine(persona2);
         Console.WriteLine(persona3);
         Console.WriteLine("\n -> empresas cargadas: ");
         Console.WriteLine(empresa1);
         Console.WriteLine(empresa2);
         Console.WriteLine(empresa3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando lineas...");
         Linea linea1 = new Linea(376, 469853, equipo1, persona1);
         Linea linea2 = new Linea(376, 568432, equipo2, persona3);
         Linea linea3 = new Linea(376, 436952, equipo3, empresa3);
         Console.WriteLine("\n lineas cargadas: ");
         linea2.Suspender();
         linea3.Suspender();
         linea3.Reactivar();
         Console.WriteLine(linea1);
         Console.WriteLine(linea2);
         Console.WriteLine(linea3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando servicios...");
         Voz voz1 = new Voz(300, 600);
         Voz voz2 = new Voz(300, 1200);
         Voz voz3 = new Voz(300, 300);
         Sms mensajes1 = new Sms(200, 200);
         Sms mensajes2 = new Sms(200, 500);
         Sms mensajes3 = new Sms(200, 100);
         Dato datos1 = new Dato(500, 2048);
         Dato datos2 = new Dato(500, 4096);
         Dato datos3 = new Dato(500, 1024);

         Console.WriteLine("\n servicios cargados: ");
         Console.WriteLine(" voz: ");
         Console.WriteLine($" - {voz1}");
         Console.WriteLine($" - {voz2}");
         Console.WriteLine($" - {voz3}");
         Console.WriteLine(" mensajes: ");
         Console.WriteLine($" - {mensajes1}");
         Console.WriteLine($" - {mensajes2}");
         Console.WriteLine($" - {mensajes3}");
         Console.WriteLine(" datos: ");
         Console.WriteLine($" - {datos1}");
         Console.WriteLine($" - {datos2}");
         Console.WriteLine($" - {datos3}");

         Console.WriteLine(divisor);
         Console.WriteLine(" creando paquetes...");
         Paquete paquete1 = new Paquete();
         Paquete paquete2 = new Paquete();
         Paquete paquete3 = new Paquete();
         paquete1.Nombre = "mensajes + datos";
         paquete2.Nombre = "voz + mensajes";
         paquete3.Nombre = "voz + mensajes + datos";
         paquete1.AddServicio(mensajes2);
         paquete1.AddServicio(datos2);
         paquete2.AddServicio(voz1);
         paquete2.AddServicio(mensajes1);
         paquete3.AddServicio(voz3);
         paquete3.AddServicio(mensajes3);
         paquete3.AddServicio(datos3);
         Console.WriteLine("\n paquetes cargados: ");
         MostrarPaquete(paquete1);
         MostrarPaquete(paquete2);
         MostrarPaquete(paquete3);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando planes en lineas: ");
         linea1.Plan = paquete2;
         linea3.Plan = paquete3;
         Console.WriteLine("\n creando consumos...");
         // linea 1
         mensajes2.NuevoConsumo(10);
         mensajes2.NuevoConsumo(30);
         mensajes2.NuevoConsumo(3);
         datos2.NuevoConsumo(60);
         datos2.NuevoConsumo(30);
         datos2.NuevoConsumo(70);
         // linea 3
         voz3.NuevoConsumo(15);
         voz3.NuevoConsumo(8);
         voz3.NuevoConsumo(20);
         mensajes3.NuevoConsumo(3);
         mensajes3.NuevoConsumo(5);
         mensajes3.NuevoConsumo(21);
         datos3.NuevoConsumo(30);
         datos3.NuevoConsumo(100);

         Console.WriteLine("\n GetConsumos()");
         Console.WriteLine($" consumos de paquete {paquete1.Nombre}: ");
         Console.WriteLine(paquete1.GetConsumosToString());
         Console.WriteLine($" consumos de paquete {paquete3.Nombre}: ");
         Console.WriteLine(paquete3.GetConsumosToString());

         Console.WriteLine(" GetDisponibleToString()");
         Console.WriteLine($" disponible de {paquete1.Nombre}:");
         Console.WriteLine(paquete1.GetDisponibleToString());
         Console.WriteLine($" disponible de {paquete3.Nombre}");
         Console.WriteLine(paquete3.GetDisponibleToString());

         //Console.WriteLine("");
         //Console.WriteLine();
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarPaquete(Paquete paquete)
      {
         Console.WriteLine($" paquete {paquete.Nombre}: ");
         foreach (var servicio in paquete.GetAllServicios())
         {
            Console.WriteLine(" - " + servicio);
         }
         Console.WriteLine();
      }
   }
}
