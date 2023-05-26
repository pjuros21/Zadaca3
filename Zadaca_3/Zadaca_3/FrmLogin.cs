using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_3 {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e) {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            if (korisnickoIme == "" || lozinka == "") {
                MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if (korisnickoIme == "zaposlenik" && lozinka == "123") {
                MessageBox.Show("Uspješno ste se prijavili!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                FrmPregledZahtjeva frmPregledZahtjeva = new FrmPregledZahtjeva();   
                frmPregledZahtjeva.ShowDialog();
                Close();
            }
            else {
                MessageBox.Show("Podaci nisu ispravni!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }
    }
}
