using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnMasaSiparis_Click(object sender, EventArgs e)
        {

            MasalarForm frm = new MasalarForm();
            this.Close();
            frm.Show();
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            RezervasyonForm frm = new RezervasyonForm();
            this.Close();
            frm.Show();

        }

        private void BtnPaketServis_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            this.Close();
            frm.Show();
        }

        private void BtnMüsteriler_Click(object sender, EventArgs e)
        {
            MüsterilerForm frm = new MüsterilerForm();
            this.Close();
            frm.Show();

        }

        private void BtnKasaİslemleri_Click(object sender, EventArgs e)
        {
            KasaİslemleriForm frm = new KasaİslemleriForm();
            this.Close();
            frm.Show();
        }

        private void BtnMutfak_Click(object sender, EventArgs e)
        {
            MutfakForm frm = new MutfakForm();
            this.Close();
            frm.Show();
        }

        private void BtnRaporlar_Click(object sender, EventArgs e)
        {
            RaporlarForm frm = new RaporlarForm();
            this.Close();
            frm.Show();
        }

        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm frm = new AyarlarForm();
            this.Close();
            frm.Show();
        }

        private void BtnKilit_Click(object sender, EventArgs e)
        {
            KilitForm frm = new KilitForm();
            this.Close();
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "UYARI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
