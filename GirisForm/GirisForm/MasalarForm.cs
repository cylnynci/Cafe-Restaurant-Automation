using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GirisForm
{
    public partial class MasalarForm : Form
    {
        public MasalarForm()
        {
            InitializeComponent();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "UYARI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnGeriDön_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm();
            this.Close();
            frm.Show();
        }

        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa1.Text.Length;

            cGenel._ButtonValue = BtnMasa1.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa2.Text.Length;

            cGenel._ButtonValue = BtnMasa2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa3.Text.Length;

            cGenel._ButtonValue = BtnMasa3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa4.Text.Length;

            cGenel._ButtonValue = BtnMasa4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa5_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa5.Text.Length;

            cGenel._ButtonValue = BtnMasa5.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa6_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa6.Text.Length;

            cGenel._ButtonValue = BtnMasa6.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa7_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa7.Text.Length;

            cGenel._ButtonValue = BtnMasa7.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa8_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa8.Text.Length;

            cGenel._ButtonValue = BtnMasa8.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa9_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa9.Text.Length;

            cGenel._ButtonValue = BtnMasa9.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa10_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            int uzunluk = BtnMasa10.Text.Length;

            cGenel._ButtonValue = BtnMasa10.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = BtnMasa10.Name;
            this.Close();
            frm.ShowDialog();
        }

        cGenel gnl = new cGenel();
        private void MasalarForm_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM,ID from Masalar", con);
            SqlDataReader dr = null;
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name=="BtnMasa"+dr["ID"].ToString() && dr["DURUM"].ToString()=="1")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Masa);

                        }
                        else if (item.Name == "BtnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2")
                        {
                            cMasalar ms = new cMasalar();
                            DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2)).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark=t2 - t1;

                              // item.Text = String.Format("{0}{1}{2}",
                              // fark.Days > 0 ? string.Format("{0} Gün", fark.Days) : "",
                              //fark.Hours > 0 ? string.Format("{0} Saat", fark.Hours) : "",
                              //fark.Minutes > 0 ? string.Format("{0} Dakika", fark.Minutes) : "").Trim() + "?\n\n\nMasa" + dr["ID"].ToString();

                                 item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Dolu1);
                        }
                        else if (item.Name == "BtnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "3")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.AçıkRezerve1);
                        }
                        else if (item.Name == "BtnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "4")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Rezerve1s);
                        }
                    }
                }
            }
        }
    }
}
