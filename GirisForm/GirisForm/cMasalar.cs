using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisForm
{
    class cMasalar
    {
        #region Fields
        private int _Id;
        private int _Kapasite;
        private int _ServisTürü;
        private int _Durum;
        private int _Onay;
        #endregion

        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int Kapasite { get => _Kapasite; set => _Kapasite = value; }
        public int ServisTürü { get => _ServisTürü; set => _ServisTürü = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int Onay { get => _Onay; set => _Onay = value; }
        #endregion

        cGenel gnl = new cGenel();
        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaId From Adisyon Right Join Masalar on Adisyon.MasaId=Masalar.Id where Masalar.Durum=@durum and Adisyon.Durum=0", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();

            }
            return dt;
        }
    }
}
