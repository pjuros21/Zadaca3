using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_3.Models {
    public class Zahtjev {
        public int Id_Zahtjeva { get; set; }
        public DateTime PocetakOdsutnosti { get; set; } 
        public DateTime ZavrsetakOdsutnosti { get; set; }
        public string Opis { get; set; }
        public int Id_VrsteOdsutnosti { get; set; }
        public int Id_Menadzera { get; set; }
    }
}
