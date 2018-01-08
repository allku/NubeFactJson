using System;

namespace NubeFactJson
{
    public class NubeFacT
    {
        public static void Main()
        {
            // 1 ingrese la fecha
            // 2 ingrese 1 no enviadas    2 enviadas  3 todas
            // 3 op 1 solo reporte    2 enviar   3 verificar
            // 4 Probar conexión
            probarConexion();
           
           
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

        static void enviar(string fecha)
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