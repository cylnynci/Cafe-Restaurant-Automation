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
    public partial class FrmGrs : Form
    {
        public FrmGrs()
        {
            InitializeComponent();
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmGrs_Load(object sender, EventArgs e)
        {

            cPersoneller p = new cPersoneller();
            p.personelBilgileriniGetir(CbKullanici);


        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool sonuc = p.personelGirisKontrol(TxtSifre.Text,cGenel._personelId);

            if (sonuc)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş Yaptı.";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış!", "Uyarı!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {

            cPersoneller p = (cPersoneller)CbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGörevId;

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?","UYARI!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
