using System;

namespace NubeFactJson
{
    public class Program
    {
        public static void Main()
        {
            //var enviar = new Enviar();
            //enviar.ejemplo();

             ConsoleKeyInfo op;
             do
             {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\tFacturación Electrónica con Nubefact\n");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("[ N ] Reporte( Factura | Boleta ) NO Enviadas\t\n");
                Console.Write("[ S ] Reporte( Factura | Boleta ) SI Enviadas \t\n");
                Console.Write("[ T ] Reporte( Factura | Boleta ) Todas\t\n");
                Console.Write("[ E ] Enviar a Nubefact\t\n");
                Console.Write("[ V ] Verificar\t\n");
                Console.Write("\n");
                Console.Write("[ P ] Probar conexión\t\n");
                Console.Write("\n");
                Console.Write("[ Esc ]Salir\t\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);//Que no muestre la tecla señalada
                DateTime fecha;
                String FechaAValidar = null;
                 //métodos son acciones, las propiedades son valores
                switch (op.Key)
                {
                     case ConsoleKey.P:
                         Console.WriteLine("[ P ] Probar la conexión");
                         probarConexion();
                         Console.Write("Presione una tecla para continuar...");
                         Console.ReadKey();
                         break;

                     case ConsoleKey.N:
                         Console.WriteLine("[ N ] Reporte (Facturas|Boletas) No Enviadas");
                         Console.WriteLine(" Ingrese una fecha(dd-mm-yyyy):");
                         FechaAValidar = Console.ReadLine();
                         if (DateTime.TryParse(FechaAValidar, out fecha))
                         {   
                             reporteNoEnviadas(FechaAValidar);
                         }else {
                             Console.WriteLine("La fecha no cumple con el FORMATO(dd-mm-yyyy):");
                         }
                         Console.Write(" Presione una tecla para continuar...");
                         Console.ReadKey();
                         break;

                     case ConsoleKey.S:
                         Console.WriteLine("[ S ] Reporte (Facturas|Boletas) Si Enviadas");
                         Console.WriteLine(" Ingrese una fecha(dd-mm-yyyy):");
                         FechaAValidar = Console.ReadLine();
                         if (DateTime.TryParse(FechaAValidar, out fecha))
                         {
                             reporteEnviadas(FechaAValidar);
                         }
                         else
                         {
                             Console.WriteLine("La fecha no cumple con el FORMATO(dd-mm-yyyy):");
                         }
                         Console.Write(" Presione una tecla para continuar...");
                         Console.ReadKey();
                         break;

                     case ConsoleKey.T:
                         Console.WriteLine("[ T ] Reporte (Facturas|Boletas)Todas");
                         Console.WriteLine(" Ingrese una fecha(dd-mm-yyyy):");
                         FechaAValidar = Console.ReadLine();
                         if (DateTime.TryParse(FechaAValidar, out fecha))
                         {
                             reporteTodas(FechaAValidar);
                         }
                         else
                         {
                             Console.WriteLine("La fecha no cumple con el FORMATO(dd-mm-yyyy):");
                         }
                         Console.Write(" Presione una tecla para continuar...");
                         Console.ReadKey();
                         break;

                     case ConsoleKey.E:
                         Console.WriteLine("[ E ] Enviar a Nubefact");
                         Console.WriteLine(" Ingrese una fecha(dd-mm-yyyy):");
                         FechaAValidar = Console.ReadLine();
                         if (DateTime.TryParse(FechaAValidar, out fecha))
                         {
                             enviarNubeFact(FechaAValidar);                         
                         }
                         else
                         {
                             Console.WriteLine("La fecha no cumple con el FORMATO(dd-mm-yyyy):");
                         }
                         Console.Write(" Presione una tecla para continuar...");
                         Console.ReadKey();
                         break;

                     case ConsoleKey.V:
                         Console.WriteLine("[ V ] Verificar");
                         Console.WriteLine("Ingrese una fecha(dd-mm-yyyy):");
                         FechaAValidar = Console.ReadLine();
                         if (DateTime.TryParse(FechaAValidar, out fecha))
                         {
                             verificar(FechaAValidar);
                         }
                         else
                         {
                             Console.WriteLine("La fecha no cumple con el FORMATO(dd-mm-yyyy):");
                         }
                         Console.Write(" Presione una tecla para continuar...");
                         Console.ReadKey();
                         break;


                     case ConsoleKey.Escape:
                         Console.WriteLine("Saliendo ... ");

                         break;
                }
             } while (op.Key != ConsoleKey.Escape);           
        }

        static void reporteNoEnviadas(string fecha) {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = fecha;
            reporteFactura.reporte(ReporteFactura.NO_ENVIADO);
        }

        static void reporteEnviadas(string fecha)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = fecha;
            reporteFactura.reporte(ReporteFactura.ENVIADO);
        }

        static void reporteTodas(string fecha)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = fecha;
            reporteFactura.reporte(ReporteFactura.TODOS);
        }

        static void enviarNubeFact(string fecha)
        {
            var nubeFact = new NubeFact();
            nubeFact.fecha = fecha;
            nubeFact.enviar();
        }

        static void verificar(string fecha)
        {
            var nubeFact = new NubeFact();
            nubeFact.fecha = fecha;
            nubeFact.verificar();
        }

        static void probarConexion()
        {
            var c = new Connection();
            c.initSqlServer();
            c.probarSqlServerConnection();
        }
    }
}