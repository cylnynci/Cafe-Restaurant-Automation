using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace GirisForm
{
    class cPersoneller
    {

        cGenel gnl = new cGenel();
        #region Fields
        private int _personelId;
        private int _personelGörevId;
        private string _personelAd;
        private string _personelSoyad;
        private string _personelParola;
        private string _personelKullaniciAdi;
        private bool _PersonelDurum;

        #endregion
        #region Properties
        public int PersonelId { get => _personelId; set => _personelId = value; }
        public int PersonelGörevId { get => _personelGörevId; set => _personelGörevId = value; }
        public string PersonelAd { get => _personelAd; set => _personelAd = value; }
        public string PersonelSoyad { get => _personelSoyad; set => _personelSoyad = value; }
        public string PersonelParola { get => _personelParola; set => _personelParola = value; }
        public string PersonelKullaniciAdi { get => _personelKullaniciAdi; set => _personelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; } 
        #endregion


        public bool personelGirisKontrol(string sifre, int kullaniciId)
        {

            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select*from Personeller where Id=@Id and Parola=@sifre", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = kullaniciId;
            cmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;

            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }


            return sonuc;
        }
        public void personelBilgileriniGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select*from Personeller ", con);
           
            
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p._personelId = Convert.ToInt32(dr["Id"]);
                p._personelGörevId = Convert.ToInt32(dr["GörevId"]);
                p._personelAd = Convert.ToString(dr["Ad"]);
                p._personelSoyad = Convert.ToString(dr["Soyad"]);
                p._personelParola = Convert.ToString(dr["Parola"]);
                p._personelKullaniciAdi = Convert.ToString(dr["KullaniciAdi"]);
                p._PersonelDurum = Convert.ToBoolean(dr["Durum"]);
                cb.Items.Add(p);




            }

            dr.Close();
            con.Close();

        }
        public override string ToString()
        {
            return PersonelAd +" "+ PersonelSoyad;
        }
    }
}
