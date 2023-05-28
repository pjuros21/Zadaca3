using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_3.Models;

namespace Zadaca_3.Repozitorij {
    public class RepozitorijMenadzera {

        public static Menadzer GetMenadzer(int id_Menadzera) {
            Menadzer menadzer = null;
            string sql = $"SELECT * FROM Menadzer WHERE Id_Menadzera = {id_Menadzera}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows) {
                reader.Read();
                menadzer = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return menadzer;
        }

        public static List<Menadzer> GetMenadzeri() { 
            List<Menadzer> menadzeri = new List<Menadzer>();

            string sql = "SELECT * FROM Menadzeri";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Menadzer menadzer = CreateObject(reader);
                menadzeri.Add(menadzer);
            }

            reader.Close();
            DB.CloseConnection();

            return menadzeri;
        }

        private static Menadzer CreateObject(SqlDataReader reader) {
            int id_Menadzera = int.Parse(reader["Id_Menadzera"].ToString());
            string nazivMenadzera = reader["NazivMenadzera"].ToString();

            var menadzer = new Menadzer {
                Id_Menadzera = id_Menadzera,
                NazivMenadzera = nazivMenadzera
            };

            return menadzer;
        }
    }
}
