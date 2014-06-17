using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaunchAll
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // LaunchAll
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 1)
            {
                Application.Run(new frmLaunchAll(args[0]));
            }
            else
                Application.Run(new frmLaunchAll());
        }
    }
}
