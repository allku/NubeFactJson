

namespace NubeFactJson
{
    public class NubeFacT
    {
        public static void Main()
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = "01-10-2017";
            reporteFactura.reporte(ReporteFactura.TODOS);



     
            //var enviar = new Enviar();

            //var generaFactura = new GeneraFactura("1", "F009", "80");
            //var factura = generaFactura.genera();
            //enviar.ejemplo();

            // 1 ingrese la fecha
            // 2 ingrese 1 no enviadas    2 enviadas  3 todas
            // 3 op 1 solo reporte    2 enviar   3 verificar

            //probarSqlServerConnection();
            //var generaFactura = new GeneraFactura("1", "F009", "80");
            //generaFactura.genera();
        }
    }
}