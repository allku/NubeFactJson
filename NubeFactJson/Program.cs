using System;
using System.Configuration;
using System.Windows.Forms;

namespace NubeFactJson
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());        
        }
        static void Configuracion()
        {
            var enviar = new Enviar();
            Console.WriteLine(enviar.ruta); 
            Console.WriteLine(enviar.token); 
        }
    }
}