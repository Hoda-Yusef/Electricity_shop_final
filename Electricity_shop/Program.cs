//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Windows.Forms;

namespace Electricity_shop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_ContainerData(1));
        }
    }
}
