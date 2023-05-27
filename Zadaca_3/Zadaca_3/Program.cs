using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;


namespace Zadaca_3 {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("PI2023_IPS23_pjuros21_DB", "pjuros21", "gQ_Xo({m");
            Application.Run(new FrmLogin());
        }
    }
}
