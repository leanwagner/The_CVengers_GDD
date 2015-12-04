using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Login;
using System.Globalization;
using System.Threading;

namespace AerolineaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
            culture.DateTimeFormat.LongDatePattern = "dddd,dd' de 'MMMM' de 'yyyy";
            culture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            culture.DateTimeFormat.ShortTimePattern = "HH:mm";
            culture.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Sunday;
            Thread.CurrentThread.CurrentCulture = culture;
            Conexion.getConexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login.Login());
        }
    }
}
