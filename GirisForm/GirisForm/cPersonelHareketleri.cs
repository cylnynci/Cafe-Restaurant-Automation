using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GirisForm
{
    class cPersonelHareketleri
    {

        cGenel gnl = new cGenel();
        #region Fields
        private int _Id;
        private int _personelId;
        private string _islem;
        private DateTime _tarih;
        private bool _durum;
        #endregion

        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int PersonelId { get => _personelId; set => _personelId = value; }
        public string Islem { get => _islem; set => _islem = value; }
        public DateTime Tarih { get => _tarih; set => _tarih = value; }
        public bool Durum { get => _durum; set => _durum = value; } 
        #endregion  

        public bool PersonelActionSave(cPersonelHareketleri ph)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into PersonelHareketleri(PersonelId,Islem,Tarih)values(@PersonelId,@Islem,@Tarih)", con);

            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@PersonelId", SqlDbType.Int).Value = ph._personelId;//Daha güvenlikli ve daha hızlı olduğundan
                cmd.Parameters.Add("@Islem", SqlDbType.VarChar).Value = ph._islem;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = ph._tarih;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());


            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
                throw;
            }
            return result;
        }
    
    }
}
