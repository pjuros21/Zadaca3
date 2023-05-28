using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_3.Repozitorij;

namespace Zadaca_3 {
    public partial class FrmNoviZahtjev : Form {
        public FrmNoviZahtjev() {
            InitializeComponent();
        }

        private void frmNoviZahtjev_Load(object sender, EventArgs e) {
            var menadzeri = RepozitorijMenadzera.GetMenadzeri();
            cbMenadzer.DataSource = menadzeri;
        }

        private void cbMenadzer_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
