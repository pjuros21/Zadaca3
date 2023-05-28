using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_3.Models;
using Zadaca_3.Repozitorij;

namespace Zadaca_3 {
    public partial class FrmPregledZahtjeva : Form {

        public FrmPregledZahtjeva() {
            InitializeComponent();
        }

        private void FrmPregledZahtjeva_Load(object sender, EventArgs e) {
            ShowZahtjevi();
        }

        private void ShowZahtjevi() {
            List<Zahtjev> zahtjevi = RepozitorijZahtjev.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;

            dgvZahtjevi.Columns["Id_Zahtjeva"].DisplayIndex = 0;
            dgvZahtjevi.Columns["PocetakOdsutnosti"].DisplayIndex = 1;
            dgvZahtjevi.Columns["ZavrsetakOdsutnosti"].DisplayIndex = 2;
            dgvZahtjevi.Columns["Opis"].DisplayIndex = 3;
            dgvZahtjevi.Columns["Id_VrsteOdsutnosti"].DisplayIndex = 4;
            dgvZahtjevi.Columns["Id_Menadzera"].DisplayIndex = 5;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

       
    }
}
