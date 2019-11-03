using System;
using System.Windows.Forms;

namespace Ultimate_Material_Hactool_GUI
{ 
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_Main());
        }
    }
}
