using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoComunidad.Formularios;

namespace ProyectoComunidad
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuInicio());
        }
         
    }
    static class Globales
    {
        public static string llamadas;
        public static int modificar;
        /*   public static DateTime fechafactura;
           public static string mesfactura;
           public static decimal tipoiva;
           public static string ruta;
           public static DateTime anofactura;
       */
    }
}
