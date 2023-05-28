using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;


namespace Zadaca_3 {
    public static class Program {
        
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("IPS23_pjuros21", "pjuros21", "gQ_Xo({m");
            Application.Run(new FrmLogin());
        }
    }
}
