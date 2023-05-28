using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Zadaca_3.Models;


namespace Zadaca_3.Repozitorij {
    public class RepozitorijZahtjev {
        
        public static Zahtjev GetZahtjev(int id_Zahtjeva) {
            
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjev WHERE Id_Zahtjeva = {id_Zahtjeva}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            
            if (reader.HasRows) {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return zahtjev; 
        }

        public static List<Zahtjev> GetZahtjevi() {
            
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            string sql = "SELECT * FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }

        private static Zahtjev CreateObject(SqlDataReader reader) {
            int id_Zahtjeva = int.Parse(reader["Id_Zahtjeva"].ToString());
            DateTime pocetakOdsutnosti = DateTime.Parse(reader["PocetakOdsutnosti"].ToString());
            DateTime zavrsetakOdsutnosti = DateTime.Parse(reader["ZavrsetakOdsutnosti"].ToString());
            string opis = reader["Opis"].ToString();
            int id_VrsteOdsutnosti = int.Parse(reader["Id_VrsteOdsutnosti"].ToString());
            int id_Menadzera = int.Parse(reader["Id_Menadzera"].ToString());

            var zahtjev = new Zahtjev {
                Id_Zahtjeva = id_Zahtjeva,
                PocetakOdsutnosti = pocetakOdsutnosti,
                ZavrsetakOdsutnosti = zavrsetakOdsutnosti,
                Opis = opis,
                Id_VrsteOdsutnosti = id_VrsteOdsutnosti,
                Id_Menadzera = id_Menadzera
            };

            return zahtjev;
        }
            
    }
}
